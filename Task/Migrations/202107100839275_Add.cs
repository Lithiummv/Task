namespace Task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Organizations", "NameOrganization", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Organizations", "ContractNumber", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Organizations", "ContractNumber", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Organizations", "NameOrganization", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
