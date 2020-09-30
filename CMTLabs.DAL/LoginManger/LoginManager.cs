using CMTLabs.Common.POCOs;
using System.Linq;
using CMTLabs.DAL.ManagersBase;
using AutoMapper;

namespace CMTLabs.DAL.LoginManger
{
    public class LoginManager : ManagerBase, ILoginManager
    {
        //MapperManager.MapperManager mapperManager = new MapperManager.MapperManager();
        public EmployeeDTO CheckUserAndPassword(EmployeeDTO employeeDTO)
        {
            var employee = Entities.Employees.Include("UsersRole").Where(att => att.UserName == employeeDTO.UserName && att.Password == employeeDTO.Password).FirstOrDefault();

            // Log the login attempt in Login_logout_Lot Table.....

            if (employee != null)
            {
                employeeDTO = Mapper.Map<Employee, EmployeeDTO>(employee);

                employeeDTO.UserRoleLookupId = employee.UsersRole.RoleNameLookupId;

                return employeeDTO;
            }
            else
                return employeeDTO;


        }
    }
}
