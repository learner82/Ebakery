namespace Ebakery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataannotationsCoupon : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coupons", "CouponCode", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Coupons", "Description", c => c.String(nullable: false, maxLength: 2500));
            AlterColumn("dbo.Coupons", "DiscountCategory", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coupons", "DiscountCategory", c => c.String(maxLength: 250));
            AlterColumn("dbo.Coupons", "Description", c => c.String(maxLength: 2500));
            AlterColumn("dbo.Coupons", "CouponCode", c => c.String(maxLength: 100));
        }
    }
}
