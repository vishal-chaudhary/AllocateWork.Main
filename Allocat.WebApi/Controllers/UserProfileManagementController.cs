using Allocat.DataModel;
using Allocat.WebApi.WebApiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Allocat.WebApi.Controllers
{
    public class UserProfileManagementController : ApiController
    {
        public HttpResponseMessage GetUserProfile()
        {
            Admin_UserProfileApiModel userProfile = new Admin_UserProfileApiModel();
            TransactionalInformation transaction = new TransactionalInformation();


        }
    }
}
