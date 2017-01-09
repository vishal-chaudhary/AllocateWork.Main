using Allocat.DataModel;
using Allocat.DataServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allocat.DataService
{
    public class UserManagementDataService : EntityFrameworkDataService, IUserManagementDataService
    {
        public IEnumerable<sp_User_GetProfile_Result> GetUserProfile(string UserName, out TransactionalInformation transaction)
        {
            transaction = new TransactionalInformation();
            IEnumerable<sp_User_GetProfile_Result> listUsers = dbConnection.sp_User_GetProfile_Result(UserName);

            int numberOfRows = 0;
            numberOfRows = (from user in dbConnection.User
                                where user.UserName == UserName
                                select user).Count();

            transaction.ReturnStatus = true;
            transaction.ReturnMessage.Add(numberOfRows.ToString() + " Users found.");

            return listUsers;
        }
    }
}
