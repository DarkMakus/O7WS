using System;
using System.Collections.Generic;
using Angkor.O7Common.Data.Entity;

namespace Angkor.O7Common.Data.Provider
{
    public interface SecurityProvider : IDisposable
    {
        string EncryptPassword (string password);

        List<User> FindUsers (string nickName, string password);
    }
}