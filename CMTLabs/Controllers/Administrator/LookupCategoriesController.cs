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
                return RedirectToAction("LookupCategoriesHome");
            }
            else
                return View(model);

        }

        public ActionResult Details(int Id)
        {
            var objLookupCategoryDTO = AdminOperation.GetLookupCategoryWithLookupChilds(Id);

            if (objLookupCategoryDTO != null)
            {
                var objLookupCategoryObjectModel = Mapper.Map<LookupCategoryDTO, LookupCategoiresObjectModel>(objLookupCategoryDTO);
                return View(objLookupCategoryObjectModel);
            }
            else
            {
                return View("NotFound");
            }

        }

        [HttpGet]
        public ActionResult EditLookupCategory(int Id)
        {
            var objLookupCategoryDTO = AdminOperation.GetLookupCategoryById(Id);

            if (objLookupCategoryDTO != null)
            {
                var objLookupCategoryObjectModel = Mapper.Map<LookupCategoryDTO, LookupCategoiresObjectModel>(objLookupCategoryDTO);
                return View(objLookupCategoryObjectModel);
            }
            else
            {
                return View("NotFound");
            }
        }

        [HttpPost]
        public ActionResult EditLookupCategory(LookupCategoiresObjectModel model)
        {
            if (ModelState.IsValid)
            {
                var objLookupCateoryDTO = Mapper.Map<LookupCategoiresObjectModel, LookupCategoryDTO>(model);

                AdminOperation.UpdateLookupCategory(objLookupCateoryDTO);

                return RedirectToAction("LookupCategoriesHome");
            }
            return View(model);
        }
    }
}