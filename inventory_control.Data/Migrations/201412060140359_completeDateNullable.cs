namespace inventory_control.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class completeDateNullable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "CompleteTimestamp", c => c.DateTime());
            AlterColumn("dbo.Orders", "CompleteTimestamp", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "CompleteTimestamp", c => c.DateTime(nullable: false));
            DropColumn("dbo.Suppliers", "CompleteTimestamp");
        }
    }
}
