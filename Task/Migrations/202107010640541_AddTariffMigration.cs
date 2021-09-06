namespace Task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTariffMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tariffs",
                c => new
                    {
                        TariffId = c.Int(nullable: false, identity: true),
                        TariffOrder = c.Double(nullable: false),
                        VATOrder = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TariffId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tariffs");
        }
    }
}
