﻿using Allocat.DataModel;
using Allocat.DataServiceInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allocat.ApplicationService
{
    public class RFQBusinessRule : ValidationRules
    {
        /// <summary>
        /// Initialize user Business Rules
        /// </summary>
        /// <param name="user"></param>
        /// <param name="dataService"></param>
        public void InitializeRFQBusinessRule(RequestForQuote requestForQuote)
        {
            InitializeValidationRules(requestForQuote);
        }

        public void ValidateResponse(int TissueBankId, string ResponseBody, string AttachmentName, int CreatedBy, int LastModifiedBy, int RequestForQuoteId, int StatusId, string DeclineRemark, int Quantity, decimal UnitPrice, decimal LineTotal, decimal SalesTax, decimal Total, DateTime? TissueBankSendByDate, string ShippingMethod)
        {

        }
    }
}
