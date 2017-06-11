namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelsUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coupons", "CouponCode", c => c.String(maxLength: 100));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Surname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "StreetName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "StreetNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Category", c => c.String(maxLength: 100));
            DropColumn("dbo.Coupons", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coupons", "Name", c => c.String());
            AlterColumn("dbo.Products", "Category", c => c.String());
            AlterColumn("dbo.Users", "StreetNumber", c => c.String());
            AlterColumn("dbo.Users", "StreetName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Users", "Surname", c => c.String(maxLength: 100));
            AlterColumn("dbo.Users", "Name", c => c.String(maxLength: 100));
            DropColumn("dbo.Coupons", "CouponCode");
        }
    }
}
