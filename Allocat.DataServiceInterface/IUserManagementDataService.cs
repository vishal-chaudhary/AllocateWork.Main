using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allocat.DataModel;

namespace Allocat.DataServiceInterface
{
    public interface IUserManagementDataService : IDataService, IDisposable
    {
        IEnumerable<sp_User_GetProfile_Result> GetUserProfile(string UserName, out TransactionalInformation transactionalInformation);
    }
}
