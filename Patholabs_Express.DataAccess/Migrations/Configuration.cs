namespace Patholabs_Express.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Patholabs_Express.DataAccess.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<Patholabs_Express.DataAccess.Patholabs_ExpressModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Patholabs_Express.DataAccess.Patholabs_ExpressModel context)
        {
            var u1 = new User_Admin() { Id = 101, Name = "Sejal", Address = "Jaipur", Age = 51, Gender = "F", Email = "gunnu@gmail.com", Contact_No = "1234567890", IsAdmin = true, Password = "sej@123" };
            var u2 = new User_Admin() { Id = 102, Name = "Apoorv", Address = "Jaipur", Age = 41, Gender = "F", Email = "gunnu@gmail.com", Contact_No = "7734567890", IsAdmin = true, Password = "sej@7723" };
            context.User_Admins.AddOrUpdate(u => u.Id, u1,u2);
        }
    }
}
