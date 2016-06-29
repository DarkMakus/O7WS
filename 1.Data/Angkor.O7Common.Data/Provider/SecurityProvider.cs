using System;
using System.Collections.Generic;
using Angkor.O7Common.Data.Entity;

namespace Angkor.O7Common.Data.Provider
{
    public interface SecurityProvider : IDisposable
    {
        string EncryptPassword (string password);

        List<CTDMUSRCIA> FindUsers (string nickName, string password);

        CTDMUSRCIA FindUser(string companyId, string branchId, string nickName);

        string CompanyDescription (string id);

        string BranchDescription (string companyId, string branchId);
    }
}