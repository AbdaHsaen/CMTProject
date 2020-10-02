using AutoMapper;
using CMTLabs.BLL.Admin;
using CMTLabs.Common.POCOs;
using CMTLabs.Models.Administrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMTLabs.Controllers.Administrator
{
    public class EmployeesController : Controller
    {
        AdminOperation adminOperation;
        public EmployeesController()
        {
            if (adminOperation == null)
                adminOperation = new AdminOperation();
        }
        // GET: Employees
        public ActionResult EmployeesHome()
        {

            var lstEmployeesDto = adminOperation.GetAllEmployees();

            var employeeObjectModels = Mapper.Map<List<EmployeeDTO>, List<EmployeeObjectModel>>(lstEmployeesDto);

            return View(employeeObjectModels);
        }
    }
}