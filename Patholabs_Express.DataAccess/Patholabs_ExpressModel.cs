using System;
using System.Data.Entity;
using System.Linq;
using Patholabs_Express.DataAccess.Entities;

namespace Patholabs_Express.DataAccess
{
    public class Patholabs_ExpressModel : DbContext
    {
        public Patholabs_ExpressModel()
            : base("name=Patholabs_ExpressModel")
        {
        }

        public DbSet<User_Admin> User_Admins { get; set; }






    }
}