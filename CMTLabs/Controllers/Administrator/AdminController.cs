using AutoMapper;
using CMTLabs.BLL.Admin;
using CMTLabs.Common.POCOs;
using CMTLabs.Models.Administrator;
using CMTLabs.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMTLabs.Controllers.Administrator
{
    //[Authorize]

    public class AdminController : Controller
    {
        AdminOperation adminOperation;
        public AdminController()
        {
            if (adminOperation == null)
                adminOperation = new AdminOperation();
        }
        // GET: Home
        public ActionResult AdminHome(EmployeeDTO employeeDTO)
        {
            var lstEmployeesDto = adminOperation.GetAllEmployees();

            var employeeObjectModels = Mapper.Map<List<EmployeeDTO>, List<EmployeeObjectModel>>(lstEmployeesDto);

            return View(employeeObjectModels);
        }

        public ActionResult CreateNewEmployee()
        {
            return View();
        }

    }
}