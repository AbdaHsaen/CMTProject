using CMTLabs.Common.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.BLL.LoginUsers
{
   public interface ILoginUsers
    {
         EmployeeDTO UserLogin(EmployeeDTO loginDTO);
    }
}
