namespace inventory_control.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class viewModelPass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "UserDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "AdminConfirmDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "IsDenied", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "DeniedReason", c => c.String());
            AddColumn("dbo.Items", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "IsDeleted");
            DropColumn("dbo.Orders", "DeniedReason");
            DropColumn("dbo.Orders", "IsDenied");
            DropColumn("dbo.Orders", "AdminConfirmDeleted");
            DropColumn("dbo.Orders", "UserDeleted");
        }
    }
}
