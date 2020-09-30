using AutoMapper;
using CMTLabs.Common.POCOs;
using CMTLabs.DAL.ManagersBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlClient;

namespace CMTLabs.DAL.LookupCategories
{
    public class LookupCategoryManager : ManagerBase, ILookupCategoryManager
    {
        public void AddNewLookupCategory(LookupCategoryDTO lookupCategoryDTO)
        {
            lookupCategoryDTO.ModifedDate = lookupCategoryDTO.CreatedDate;

            var lookupCategory = Mapper.Map<LookupCategoryDTO, LookupCategory>(lookupCategoryDTO);

            Entities.LookupCategories.Add(lookupCategory);

            Entities.Entry(lookupCategory).State = EntityState.Added;

            Entities.SaveChanges();
        }

        public void DeleteLookupCategory(int LookupCategoryId)
        {
            throw new NotImplementedException();
        }

        public List<LookupCategoryDTO> GetAllLookupCategories()
        {
            var lstLookupCategories = Entities.LookupCategories.ToList();

            var lstLookupCategoriesDTO = Mapper.Map<List<LookupCategory>, List<LookupCategoryDTO>>(lstLookupCategories);

            return lstLookupCategoriesDTO;
        }

        public LookupCategoryDTO GetLookupCategoryById(int LookupCategoryId)
        {
            throw new NotImplementedException();
        }

        public void UpdateLookupCategory(LookupCategoryDTO lookupCategoriesDTO)
        {
            throw new NotImplementedException();
        }
    }
}
