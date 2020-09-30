using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.Common.EnumAndConstrants
{
    public static class Constraints
    {
        #region UserRoleCode
        public const string Admin = "Admin";
        public const string ProjectManager = "PM";
        public const string Technician = "Tec";
        public const string Dispatch = "DisP";
        #endregion

        #region AddressTypeCode
        public const string EmployeeAddress = "EmpAd";
        #endregion

        #region CountryCode
        public const string UnitedState = "US";
        #endregion

        #region StateCode
        public const string Texas = "TX";
        #endregion

        #region CityCode
        public const string Webster = "Webst";
        #endregion

        #region SuccessfullMessages
        public const string AddNewLookupCategorySuccessfully = "New Lookup Category Added Successfully.";
        #endregion
    }
}
