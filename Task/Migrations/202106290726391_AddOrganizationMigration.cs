namespace Task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrganizationMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Organizations", "Tariff", c => c.Double(nullable: false));
            AlterColumn("dbo.Organizations", "VAT", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Organizations", "VAT", c => c.Int(nullable: false));
            AlterColumn("dbo.Organizations", "Tariff", c => c.Int(nullable: false));
        }
    }
}
