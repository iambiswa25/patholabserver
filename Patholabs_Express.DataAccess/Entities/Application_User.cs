using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patholabs_Express.DataAccess.Entities
{
    public enum UserType
    {
        Admin, User
    }
    public class Application_User
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public UserType UserType { get; set; }
    }
}
