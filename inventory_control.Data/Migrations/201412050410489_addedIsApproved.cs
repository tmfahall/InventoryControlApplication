namespace inventory_control.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedIsApproved : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "IsApproved", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "IsApproved");
        }
    }
}
