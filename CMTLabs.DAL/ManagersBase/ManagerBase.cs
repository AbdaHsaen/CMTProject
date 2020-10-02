using AutoMapper;
using CMTLabs.Common.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.DAL.ManagersBase
{
    public class ManagerBase
    {
        public CMTLab_Entities Entities;
        public ManagerBase()
        {
            if (Entities == null)
                Entities = new CMTLab_Entities();

            Mapper.CreateMap<Employee, EmployeeDTO>().ReverseMap();
            Mapper.CreateMap<LookupCategory, LookupCategoryDTO>().ReverseMap();
            Mapper.CreateMap<Lookup, LookupDTO>().ReverseMap();
        }
    }
}
