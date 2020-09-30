using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.Common.POCOs
{
    public class EmployeeDTO
    {
        public int EmpId { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public DateTime DOB { get; set; }

        public DateTime AttemptDate { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Acitve { get; set; }
        public int AddressId { get; set; }

        public int UserRoleLookupId { get; set; }
    }
}
