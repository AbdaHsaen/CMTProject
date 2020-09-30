using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMTLabs.Models.Administrator
{
    public class EmployeeObjectModel
    {
        public int EmpId { get; set; }
        [DisplayName("First Name")]
        public string FName { get; set; }
        [DisplayName("Middle Name")]
        public string MName { get; set; }
        [DisplayName("Last Name")]
        public string LName { get; set; }
        [DisplayName("Date of birth")]
        public DateTime DOB { get; set; }

        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool Acitve { get; set; }
        [DisplayName("User Name")]
        public string UserRole { get; set; }
    }
}