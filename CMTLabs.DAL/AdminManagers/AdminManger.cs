using AutoMapper;
using CMTLabs.Common.POCOs;
using CMTLabs.DAL.ManagersBase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.DAL.AdminManagers
{
    public class AdminManger : ManagerBase, IAdminManger
    {
        public List<EmployeeDTO> GetEmployees()
        {

            var employees = Entities.Employees.ToList();

            List<EmployeeDTO> lstEmployeeDTO = new List<EmployeeDTO>();

            lstEmployeeDTO = Mapper.Map<List<Employee>, List<EmployeeDTO>>(employees);

            return lstEmployeeDTO;
        }
    }
}
