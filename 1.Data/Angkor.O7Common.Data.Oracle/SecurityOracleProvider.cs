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

        public CTDMUSRCIA FindUser (string companyId, string branchId, string nickName)
        {
            IQueryable<CTDMUSRCIA> result = from user in _context.CTDMUSRCIAs
                                            where user.CTUCCODUSR == nickName && user.CTUCCODCIA == companyId && user.CTUCCODSUC == branchId
                                            select user;
            return result.FirstOrDefault ( );
        }

        public string EncryptPassword (string password)
        {
            var param = new OracleParameter ("param", OracleDbType.Varchar2, password, ParameterDirection.Input);
            return _context.Database.SqlQuery<string> ("SELECT O7WEB_MD5.MD5(:param) FROM DUAL", param).FirstOrDefault ( );
        }

        public List<CTDMUSRCIA> FindUsers (string nickName, string password)
        {
            IQueryable<CTDMUSRCIA> urs =    from user in _context.CTDMUSRCIAs
                                            where user.CTUCCODUSR == nickName && user.CTUCPWDCLN == password
                                            select user;
            return urs.ToList ( );
        }

        public string CompanyDescription (string id)
        {
            var param = new OracleParameter ("cia", OracleDbType.Varchar2, id, ParameterDirection.Input);
            return _context.Database.SqlQuery<string> ("SELECT MCC_UTILBD.GET_TBLVAL('002',:cia,'DESC_LARGA') FROM DUAL", param).FirstOrDefault ( );
        }

        public string BranchDescription (string companyId, string branchId)
        {
            var param = new OracleParameter ("ciasuc", OracleDbType.Varchar2,
                string.Format ("{0}{1}", companyId, branchId), ParameterDirection.Input);
            return _context.Database.SqlQuery<string> ("SELECT MCC_UTILBD.GET_TBLVAL('002',:ciasuc,'DESC_LARGA') FROM DUAL", param).FirstOrDefault ( );
        }

        #region Implementation of IDisposable
        /// <summary>
        ///     Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose ( )
        {
            _context.Dispose ( );
        }
        #endregion
    }
}