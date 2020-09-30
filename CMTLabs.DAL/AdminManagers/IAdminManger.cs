using CMTLabs.Common.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.DAL.AdminManagers
{
  public  interface IAdminManger
    {
        List<EmployeeDTO> GetEmployees();
    }
}
