using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patholabs_Express.API.Models
{
    public class User_AdminDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Contact_No { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
        public string Password { get; set; }
    }
}