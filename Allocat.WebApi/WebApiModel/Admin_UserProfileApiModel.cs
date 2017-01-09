using Allocat.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Allocat.WebApi.WebApiModel
{
    public class Admin_UserProfileApiModel : TransactionalInformation
    {
        public IEnumerable<sp_User_GetProfile_Result> UserProfileByUserName;
    }


    public class UserProfile_DTO
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }   
    }
}