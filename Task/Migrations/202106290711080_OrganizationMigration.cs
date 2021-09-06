namespace Task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrganizationMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organizations", "ContractNumber", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Organizations", "Tariff", c => c.Int(nullable: false));
            AddColumn("dbo.Organizations", "VAT", c => c.Int(nullable: false));
            AddColumn("dbo.Organizations", "ContractDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Organizations", "AddressOrganization");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Organizations", "AddressOrganization", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Organizations", "ContractDate");
            DropColumn("dbo.Organizations", "VAT");
            DropColumn("dbo.Organizations", "Tariff");
            DropColumn("dbo.Organizations", "ContractNumber");
        }
    }
}
