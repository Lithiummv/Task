namespace Task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        CarBrand = c.String(nullable: false, maxLength: 30),
                        CarModel = c.String(nullable: false, maxLength: 30),
                        StateRegistrationNumber = c.String(nullable: false, maxLength: 15),
                        BodyCapacity = c.Double(nullable: false),
                        OrganizationId = c.Int(),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        OrganizationId = c.Int(nullable: false, identity: true),
                        NameOrganization = c.String(nullable: false, maxLength: 100),
                        AddressOrganization = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.OrganizationId);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        DateRequest = c.DateTime(nullable: false),
                        TimeRequest = c.DateTime(nullable: false),
                        WaybillNumber = c.String(nullable: false, maxLength: 15),
                        CarId = c.Int(),
                    })
                .PrimaryKey(t => t.RequestId)
                .ForeignKey("dbo.Cars", t => t.CarId)
                .Index(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Cars", "OrganizationId", "dbo.Organizations");
            DropIndex("dbo.Requests", new[] { "CarId" });
            DropIndex("dbo.Cars", new[] { "OrganizationId" });
            DropTable("dbo.Requests");
            DropTable("dbo.Organizations");
            DropTable("dbo.Cars");
        }
    }
}
