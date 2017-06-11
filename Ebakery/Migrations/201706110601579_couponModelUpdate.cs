namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class couponModelUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coupons", "ExpirationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Coupons", "DiscountCategory", c => c.String(maxLength: 250));
            AlterColumn("dbo.Coupons", "Description", c => c.String(maxLength: 2500));
            DropColumn("dbo.Coupons", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coupons", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Coupons", "Description", c => c.String(maxLength: 250));
            DropColumn("dbo.Coupons", "DiscountCategory");
            DropColumn("dbo.Coupons", "ExpirationDate");
        }
    }
}
