using AutoMapper;
using CMTLabs.BLL.Admin;
using CMTLabs.Common.EnumAndConstrants;
using CMTLabs.Common.POCOs;
using CMTLabs.Models.Administrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMTLabs.Controllers.Administrator
{
    public class LookupCategoriesController : Controller
    {
        private AdminOperation AdminOperation;
        public LookupCategoriesController()
        {
            if (AdminOperation == null)
                AdminOperation = new AdminOperation();
        }

        // GET: LookupCategories
        public ActionResult LookupCategoriesHome()
        {
            var lstLookupCategoryDTO = AdminOperation.GetLookupCategories();
            var lstLookupCategoryObjectModel = Mapper.Map<List<LookupCategoryDTO>, List<LookupCategoiresObjectModel>>(lstLookupCategoryDTO);
            return View(lstLookupCategoryObjectModel);
        }

        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Create(LookupCategoiresObjectModel model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;

                var lookupCategoryDTO = Mapper.Map<LookupCategoiresObjectModel, LookupCategoryDTO>(model);

                AdminOperation.AddNewLookupCategory(lookupCategoryDTO);
                TempData["UserMessage"] = Constraints.AddNewLookupCategorySuccessfully;
                return RedirectToAction("LookupCategoriesHome");
            }
            else
                return View(model);

        }

    }
}