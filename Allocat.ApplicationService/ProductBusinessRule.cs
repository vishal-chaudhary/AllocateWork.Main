using Allocat.DataModel;
using Allocat.DataServiceInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allocat.ApplicationService
{
    public class ProductBusinessRule : ValidationRules
    {
        //IProductDataService productDataService;

        /// <summary>
        /// Initialize user Business Rules
        /// </summary>
        /// <param name="user"></param>
        /// <param name="dataService"></param>
        public void InitializeProductBusinessRule(TissueBankProduct tissueBankProduct)
        {
            InitializeValidationRules(tissueBankProduct);
        }

        public void ValidateProductsDataTable(DataTable tempTissueBankProduct_TissueBank)
        {
            //productDataService = dataService;

            InitializeValidationRules(tempTissueBankProduct_TissueBank);

            foreach (DataRow dr in tempTissueBankProduct_TissueBank.AsEnumerable())
            {
                //Required Validations
                ValidateRequiredForTable(dr["TissueBankProductId"], "Tissue Bank Product Id");
                ValidateRequiredForTable(dr["TissueBankId"], "Tissue Bank ID");
                ValidateRequiredForTable(dr["ProductMasterId"], "Product Master Id");
                ValidateRequiredForTable(dr["ProductType"], "Product Type");
                ValidateRequiredForTable(dr["ProductCode"], "Product Code");
                ValidateRequiredForTable(dr["ProductSize"], "Product Size");
                ValidateRequiredForTable(dr["PreservationType"], "Preservation Type");
                ValidateRequiredForTable(dr["IsAvailableForSale"], "Is Available For Sale : Status");
                ValidateRequiredForTable(dr["SourceId"], "Source-Id");
                ValidateRequiredForTable(dr["LastModifiedBy"], "Last Modified By");

                //Regular Expression Validations

                ValidateNumericForTable(dr["LastModifiedBy"], "Last Modified By");
                ValidateNumericForTable(dr["SourceId"], "Source-Id");
                //ValidateIsDateOrNullOrEmptyDateForTable(dr["AvailabilityStartDate"], "Availability Start Date");
                //ValidateIsDateOrNullOrEmptyDateForTable(dr["AvailabilityEndDate"], "Availability End Date");

                if (ValidateNumericForTable(dr["TissueBankProductId"], "Tissue Bank Product Id"))
                {
                    if (Convert.ToInt16(dr["TissueBankProductId"]) > 0)
                    {
                        ValidateRequiredForTable(dr["CreatedBy"], "Created By");

                        ValidateNumericForTable(dr["CreatedBy"], "Created By");
                    }
                }
            }
        }
    }
}
