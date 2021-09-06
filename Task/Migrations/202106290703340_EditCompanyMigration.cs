namespace Task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCompanyMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Organizations", "AddressOrganization", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Organizations", "AddressOrganization", c => c.String(nullable: false, maxLength: 150));
        }
    }
}
