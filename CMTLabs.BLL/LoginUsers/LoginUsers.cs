using CMTLabs.Common.POCOs;
using CMTLabs.DAL.LoginManger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.BLL.LoginUsers
{
    public class LoginUsers : LoginBase, ILoginUsers
    {

        public EmployeeDTO UserLogin(EmployeeDTO employeeDTO)
        {
            return loginManager.CheckUserAndPassword(employeeDTO);
        }
    }
}
