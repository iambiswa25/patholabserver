namespace Patholabs_Express.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User_AdminDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User_Admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Age = c.Int(),
                        Gender = c.String(),
                        Email = c.String(),
                        Contact_No = c.String(),
                        IsAdmin = c.Boolean(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User_Admin");
        }
    }
}
