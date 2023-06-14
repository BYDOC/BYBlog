using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYBlog.UI.Models
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            IsDeleted = false;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }
        public string EmailAddress { get; set; }
        public string City { get; set; }
        public string Utype { get; set; }
        public bool IsDeleted { get; set; }



    }
}
