using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMTLabs.Controllers.Administrator
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Home()
        {
            return View();
        }
    }
}