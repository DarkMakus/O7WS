using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using Angkor.O7Common.Data.Entity;
using Angkor.O7Common.Data.Oracle;
using Angkor.O7Common.Entities;
using Angkor.O7Common.Data.Provider;
using Angkor.O7Common.Data.Utility;

namespace Angkor.O7Common.Domain
{
    public class SecurityDomain
    {
        private string _connection;

        public SecurityDomain ( )
        {
            _connection = ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString;
        }

        private List<CTDMUSRCIA> GetUserAccess (SecurityProvider provider, string nickName, string password)
        {
            string encryptedPass = provider.EncryptPassword(password);
            return provider.FindUsers(nickName, encryptedPass);
        }

        private List<Company> GetCompanies (SecurityProvider provider, List<CTDMUSRCIA> users)
        {
            var result = new List<Company>();
            foreach (CTDMUSRCIA user in users)
            {
                if(result.ExistsCompanyId (user.CTUCCODCIA)) continue;
                var companyId = user.CTUCCODCIA;
                var companyDescription = provider.CompanyDescription(companyId);
                var branches = new List<Branch> ( );
                foreach (CTDMUSRCIA USER in users.Where (usr=>usr.CTUCCODCIA == companyId))
                {
                    var branchId = USER.CTUCCODSUC;
                    var branchDescription = provider.BranchDescription(companyId, branchId);
                    branches.Add (new Branch {Id = branchId, Description = branchDescription});
                }
                var company = new Company {Id = companyId, Description = companyDescription, Branches = branches.ToArray ( )};
                result.Add (company);
            }
            return result;
        }

        public List<Company> FindCredentials (string nickname, string password)
        {                             
            using (SecurityProvider provider = new SecurityOracleProvider(_connection))
            {
                List<CTDMUSRCIA> access = GetUserAccess (provider, nickname, password);
                return GetCompanies (provider, access);                
            }
        }

        public Worker FindWorker(Company company, Branch branch, string nickname)
        {
            using (SecurityProvider provider = new SecurityOracleProvider(_connection))
            {
                CTDMUSRCIA user = provider.FindUser (company.Id, branch.Id, nickname);
                return new Worker {Id = user.CTUCCODTRA, Name = user.CTUCNOMUSR, Active = user.CTUCACTIVO};
            }
        }
    }
}