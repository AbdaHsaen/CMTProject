using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CMTLabs.Controllers.Shared
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Index()
        {
            //Session["UserInfo"] = null;
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();

            FormsAuthentication.SignOut();

            Session.Abandon();

            return RedirectToAction("Index", "Login");
           
        }
    }
}