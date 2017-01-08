using Allocat.DataModel;
using Allocat.DataServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allocat.DataService
{
    class UserManagementDataService : EntityFrameworkDataService, IUserManagementDataService
    {
        public IEnumerable<sp_User_GetProfile_Result> GetUserProfile(out TransactionalInformation transaction)
        {
            transaction = new TransactionalInformation();
            IEnumerable<sp_User_GetProfile_Result> listUsers = dbConnection.s
        }
    }
}
