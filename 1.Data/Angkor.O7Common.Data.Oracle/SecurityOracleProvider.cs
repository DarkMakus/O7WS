using System.Collections.Generic;
using System.Data;
using System.Linq;
using Angkor.O7Common.Data.Context;
using Angkor.O7Common.Data.Entity;
using Angkor.O7Common.Data.Provider;
using Oracle.ManagedDataAccess.Client;

namespace Angkor.O7Common.Data.Oracle
{
    public class SecurityOracleProvider : SecurityProvider
    {
        private readonly SecurityContext _context;

        public SecurityOracleProvider (string connection)
        {
            _context = new SecurityContext (connection);
        }

        public string EncryptPassword (string password)
        {
            var param = new OracleParameter ("param", OracleDbType.Varchar2, password, ParameterDirection.Input);
            return
                _context.Database.SqlQuery<string> ("SELECT O7WEB_MD5.MD5(:param) FROM DUAL", param).FirstOrDefault ( );
        }

        public List<User> FindUsers (string nickName, string password)
        {
            IQueryable<User> urs =  from user in _context.Users
                                    where user.CTUCCODUSR == nickName && user.CTUCPWDCLN == password
                                    select user;
            return urs.ToList ( );
        }

        #region Implementation of IDisposable
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose ( )
        {
            _context.Dispose ( );
        }
        #endregion

        
    }
}