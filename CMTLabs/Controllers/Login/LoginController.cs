using CMTLabs.BLL.Helpers;
using CMTLabs.BLL.LoginUsers;
using CMTLabs.Common.EnumAndConstrants;
using CMTLabs.Common.POCOs;
using CMTLabs.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace CMTLabs.Controllers.Login
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(LoginObjectModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeDTO employeeDTO = new EmployeeDTO();

                employeeDTO.AttemptDate = DateTime.Now;
                employeeDTO.UserName = model.UserName;
                employeeDTO.Password = model.Password;

                LoginUsers loginUsers = new LoginUsers();

                employeeDTO = loginUsers.UserLogin(employeeDTO);

                if (employeeDTO != null && employeeDTO.EmpId != 0)
                {
                    var UserRoleCode = Helper.GetLookupCode(employeeDTO.UserRoleLookupId);

                    if (UserRoleCode == Constraints.Admin)
                        return RedirectToAction("AdminHome", "Admin", employeeDTO);
                    else if (UserRoleCode == Constraints.ProjectManager)
                        return RedirectToAction("PMHome", "PM", employeeDTO);
                    else if (UserRoleCode == Constraints.Technician)
                        return RedirectToAction("TechHome", "Tech", employeeDTO);
                    else
                        return RedirectToAction("DispatchHome", "Dispatch", employeeDTO);
                }
                else
                    return View(model);
            }
            else
                return View(model);


        }
    }
}