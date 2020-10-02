using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMTLabs.Controllers.Technicians
{
    public class TechController : Controller
    {
        // GET: TechnicianHome
        public ActionResult TechHome()
        {
            return View();
        }
    }
}