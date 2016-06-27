using System.Collections.Generic;
using System.ServiceModel;
using Angkor.O7Common.Entities;

namespace Angkor.O7Common.WebService.Contracts
{
    [ServiceContract]
    public interface SecurityContract
    {
        [OperationContract]
        List <Company> FindCredentials (string nickname, string password);

        [OperationContract]
        Worker FindWorker (Company company, string nickname);
    }
}