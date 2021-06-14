using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Patholabs_Express.DataAccess.Entities
{
    public class  User_Admin
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
