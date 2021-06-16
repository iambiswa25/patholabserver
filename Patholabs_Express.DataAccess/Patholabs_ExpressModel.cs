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
        public DbSet<Test_Details> TestDetail { get; set; }
        public DbSet<Appointment_Details> Appointment_details { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Application_User> application_Users { get; set; }

    }
}