using AutoMapper;
using CMTLabs.Common.POCOs;
using CMTLabs.DAL.ManagersBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

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
            var objLookupCategory = Entities.LookupCategories.Where(x => x.LookupCategoryId == LookupCategoryId).First();

            var objLookupCategoryDTO = Mapper.Map<LookupCategory, LookupCategoryDTO>(objLookupCategory);

            return objLookupCategoryDTO;
        }

        public LookupCategoryDTO GetLookupCategoryWithLookupChilds(int LookupCategoryId)
        {
            var objLookupCategory = Entities.LookupCategories.Include("Lookups").Where(x => x.LookupCategoryId == LookupCategoryId).First();

            var objLookupCategoryDTO = Mapper.Map<LookupCategory, LookupCategoryDTO>(objLookupCategory);

            return objLookupCategoryDTO;
        }

        public void UpdateLookupCategory(LookupCategoryDTO lookupCategoriesDTO)
        {
            var objLookupCategory = Entities.LookupCategories.Where(x => x.LookupCategoryId == lookupCategoriesDTO.LookupCategoryId).First();

            objLookupCategory.CategoryName = lookupCategoriesDTO.CategoryName;
            objLookupCategory.ModifedDate = DateTime.Now;

            Entities.Entry(objLookupCategory).State = EntityState.Modified;

            Entities.SaveChanges();
        }
    }
}
