using CMTLabs.Common.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.BLL.Admin
{
    public interface IAdminOperation
    {
        List<EmployeeDTO> GetAllEmployees();

        List<LookupCategoryDTO> GetLookupCategories();

        void AddNewLookupCategory(LookupCategoryDTO lookupCategoriesDTO);
    }
}
