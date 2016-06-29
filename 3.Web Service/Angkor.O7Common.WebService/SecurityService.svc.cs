using System.Collections.Generic;
using Angkor.O7Common.Domain;
using Angkor.O7Common.Entities;
using Angkor.O7Common.WebService.Contracts;

namespace Angkor.O7Common.WebService
{
    public class SecurityService : SecurityContract
    {
        public List<Company> FindCredentials(string nickname, string password) 
            => DomainManager.Instance.SecurityDomain.FindCredentials(nickname, password);

        public Worker FindWorker (Company company, Branch branch, string nickname)
            => DomainManager.Instance.SecurityDomain.FindWorker (company, branch, nickname);
    }
}