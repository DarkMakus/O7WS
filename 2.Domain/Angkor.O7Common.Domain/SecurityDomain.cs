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
                var company = new Company {Id = companyId, Description = companyDescription, Branches = new List<Branch> ()};
                foreach (CTDMUSRCIA USER in users.Where (usr=>usr.CTUCCODCIA == companyId))
                {
                    var branchId = USER.CTUCCODSUC;
                    var branchDescription = provider.BranchDescription(companyId, branchId);
                    company.Branches.Add(new Branch { Id = branchId, Description = branchDescription });
                }
                result.Add (company);
            }
            return result;
        }

        public List<Company> FindCredentials (string nickname, string password)
        {                             
            using (SecurityProvider provider = new SecurityOracleProvider(ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString))
            {
                List<CTDMUSRCIA> access = GetUserAccess (provider, nickname, password);
                return GetCompanies (provider, access);                
            }
        }
    }
}