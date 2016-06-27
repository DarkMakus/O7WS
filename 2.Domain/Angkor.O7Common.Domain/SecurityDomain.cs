using System.Collections.Generic;
using Angkor.O7Common.Data.Oracle;
using Angkor.O7Common.Entities;
using Angkor.O7Common.Data.Provider;

namespace Angkor.O7Common.Domain
{
    public class SecurityDomain
    {
        public List<Company> FindCredentials (string nickname, string password)
        {
            using (SecurityProvider provider = new SecurityOracleProvider())
            {
                
            }
        }
    }
}