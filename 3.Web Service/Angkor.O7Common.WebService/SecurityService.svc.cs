using System;
using System.Collections.Generic;
using Angkor.O7Common.Entities;
using Angkor.O7Common.WebService.Contracts;

namespace Angkor.O7Common.WebService
{
    public class SecurityService : SecurityContract
    {
        public List <Company> FindCredentials (string nickname, string password)
        {
            throw new NotImplementedException ( );
        }

        public Worker FindWorker (Company company, string nickname)
        {
            throw new NotImplementedException ( );
        }
    }
}