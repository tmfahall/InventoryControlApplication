namespace inventory_control.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedOrderModifiedFlag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "IsQtyModified", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "OriginalQty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "OriginalQty");
            DropColumn("dbo.Orders", "IsQtyModified");
        }
    }
}
