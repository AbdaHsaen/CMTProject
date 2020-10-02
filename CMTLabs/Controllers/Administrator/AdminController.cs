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
       
        // GET: Home
        public ActionResult AdminHome()
        {
            return View();
        }
    }
}