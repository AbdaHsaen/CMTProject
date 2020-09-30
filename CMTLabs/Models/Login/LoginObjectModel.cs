using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMTLabs.Models.Login
{
    public class LoginObjectModel
    {
        [DisplayName("User Name")]
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public int RoleNameLookupId { get; set; }
        public DateTime AttemptDate { get; set; }

        public string LoginFalid { get; set; }
    }
}