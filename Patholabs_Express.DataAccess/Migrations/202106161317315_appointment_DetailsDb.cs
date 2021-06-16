namespace Patholabs_Express.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appointment_DetailsDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Application_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Age = c.Int(),
                        Gender = c.String(),
                        Email = c.String(),
                        Contact_No = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Appointment_Details",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        TestId = c.Int(nullable: false),
                        CustomerName = c.String(),
                        App_Book_Time = c.DateTime(nullable: false),
                        Email = c.String(),
                        App_Date_Time = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreatorUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Test_Details", t => t.TestId, cascadeDelete: true)
                .Index(t => t.TestId);
            
            CreateTable(
                "dbo.Test_Details",
                c => new
                    {
                        TestId = c.Int(nullable: false, identity: true),
                        TestName = c.String(),
                        TestPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TestId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointment_Details", "TestId", "dbo.Test_Details");
            DropForeignKey("dbo.Application_User", "UserId", "dbo.Users");
            DropIndex("dbo.Appointment_Details", new[] { "TestId" });
            DropIndex("dbo.Application_User", new[] { "UserId" });
            DropTable("dbo.Test_Details");
            DropTable("dbo.Appointment_Details");
            DropTable("dbo.Users");
            DropTable("dbo.Application_User");
        }
    }
}
