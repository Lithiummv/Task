namespace Task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EdiitOrganizationMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Organizations", "Tariff");
            DropColumn("dbo.Organizations", "VAT");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Organizations", "VAT", c => c.Double(nullable: false));
            AddColumn("dbo.Organizations", "Tariff", c => c.Double(nullable: false));
        }
    }
}
