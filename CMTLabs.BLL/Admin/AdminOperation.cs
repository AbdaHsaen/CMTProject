using CMTLabs.Common.POCOs;
using CMTLabs.DAL.AdminManagers;
using CMTLabs.DAL.LookupCategories;
using CMTLabs.DAL.LookupsManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.BLL.Admin
{
    public class AdminOperation : AdminOperationBase, IAdminOperation
    {

        public void AddNewLookupCategory(LookupCategoryDTO lookupCategoriesDTO)
        {
            LookupCategoryManager.AddNewLookupCategory(lookupCategoriesDTO);
        }

        public List<EmployeeDTO> GetAllEmployees()
        {

            var lstEmployeeDTO = AdminManger.GetEmployees();

            return lstEmployeeDTO;
        }

        public List<LookupCategoryDTO> GetLookupCategories()
        {
            var lstLookupCategoriesDTO = LookupCategoryManager.GetAllLookupCategories();

            return lstLookupCategoriesDTO;
        }

        public LookupCategoryDTO GetLookupCategoryById(int LookupCategoryId)
        {
            var objLookupCategoryDTO = LookupCategoryManager.GetLookupCategoryById(LookupCategoryId);

            return objLookupCategoryDTO;
        }

        public LookupCategoryDTO GetLookupCategoryWithLookupChilds(int LookupCategoryId)
        {
            var objLookupCategoryDTO = LookupCategoryManager.GetLookupCategoryWithLookupChilds(LookupCategoryId);

            return objLookupCategoryDTO;
        }

        public void UpdateLookupCategory(LookupCategoryDTO lookupCategoryDTO)
        {
            LookupCategoryManager.UpdateLookupCategory(lookupCategoryDTO);
        }
    }
}
