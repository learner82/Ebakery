namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "HasDiscount", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "OrderCounter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderCounter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "HasDiscount");
        }
    }
}
