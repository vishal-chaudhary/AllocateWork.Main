using Allocat.ApplicationService;
using Allocat.DataModel;
using Allocat.DataService;
using Allocat.DataServiceInterface;
using Allocat.Utility;
using Allocat.WebApi.WebApiModel;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System;

namespace Allocat.WebApi.Controllers
{
    public class UserProfileManagementController : ApiController
    {

        IUserManagementDataService userManagementDataService;

        public UserProfileManagementController()
        {
            userManagementDataService = new UserManagementDataService();
        }
        public HttpResponseMessage GetUserProfile(string UserName)
        {
            Admin_UserProfileApiModel admin_UserProfileModel = new Admin_UserProfileApiModel();
            TransactionalInformation transaction = new TransactionalInformation();

            UserManagementBusinessService userManagementBusinesService = new UserManagementBusinessService(userManagementDataService);

            IEnumerable<sp_User_GetProfile_Result> usersByUserName = userManagementBusinesService.GetUserProfile(UserName, out transaction);


            admin_UserProfileModel.UserProfileByUserName = usersByUserName;
            admin_UserProfileModel.IsAuthenicated = true;
            admin_UserProfileModel.ReturnStatus = transaction.ReturnStatus;
            admin_UserProfileModel.ReturnMessage = transaction.ReturnMessage;

            if (transaction.ReturnStatus == true)
            {
                var response = Request.CreateResponse<Admin_UserProfileApiModel>(HttpStatusCode.OK, admin_UserProfileModel);
                return response;
            }

            var badResponse = Request.CreateResponse<Admin_UserProfileApiModel>(HttpStatusCode.BadRequest, admin_UserProfileModel);
            return badResponse;
        }
    }
}
