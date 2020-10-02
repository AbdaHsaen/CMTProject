using CMTLabs.Common.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.DAL.LookupCategories
{
    public interface ILookupCategoryManager
    {
        void AddNewLookupCategory(LookupCategoryDTO lookupCategoryDTO);
        List<LookupCategoryDTO> GetAllLookupCategories();
        LookupCategoryDTO GetLookupCategoryById(int LookupCategoryId);
        void UpdateLookupCategory(LookupCategoryDTO lookupCategoriesDTO);

        void DeleteLookupCategory(int LookupCategoryId);

        LookupCategoryDTO GetLookupCategoryWithLookupChilds(int LookupCategoryId);
    }
}
