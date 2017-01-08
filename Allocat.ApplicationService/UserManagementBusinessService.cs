﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allocat.DataModel;
using Allocat.DataServiceInterface;

namespace Allocat.ApplicationService
{
    class UserManagementBusinessService
    {
        private IUserManagementDataService _userManagemenDataService;

        public IUserManagementDataService userManagementDataService { get { return _userManagemenDataService; } }

        public UserManagementBusinessService(IUserManagementDataService usermgmtDataService)
        {
            _userManagemenDataService = usermgmtDataService;
        }

        public IEnumerable<sp_User_GetProfile_Result> GetUserProfile(out TransactionalInformation transaction)
        {
            transaction = new TransactionalInformation();
            IEnumerable<sp_User_GetProfile_Result> listUser = null;

            try
            {
                _userManagemenDataService.CreateSession();
                listUser = _userManagemenDataService.GetUserProfile(out transaction);
            }
            catch (Exception ex)
            {
                transaction.ReturnMessage = new List<string>();
                string errorMessage = ex.Message;
                transaction.ReturnStatus = false;
                transaction.ReturnMessage.Add(errorMessage);
            }
            finally
            {
                _productDataService.CloseSession();
            }

            return listUser;

        }

        
    }
}
