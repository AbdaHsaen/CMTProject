using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMTLabs.Controllers.ProjectManagers
{
    public class PMController : Controller
    {
        // GET: ProjectManagerHome
        public ActionResult Index()
        {
            return View();
        }
    }
}