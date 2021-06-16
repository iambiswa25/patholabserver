using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patholabs_Express.DataAccess.Entities;

namespace Patholabs_Express.BuisnessLogic.DTOs
{

    public class LoginDto
    {
  


        public string Email { get; set; }
      
        public string Password { get; set; }

        public enUserType UserType { get; set; }
    }
}
