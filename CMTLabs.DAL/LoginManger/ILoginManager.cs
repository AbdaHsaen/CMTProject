using CMTLabs.Common.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.DAL.LoginManger
{
   public interface ILoginManager
    {
        EmployeeDTO CheckUserAndPassword(EmployeeDTO loginDTO);
    }
}
