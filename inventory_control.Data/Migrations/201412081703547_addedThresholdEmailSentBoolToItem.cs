namespace inventory_control.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedThresholdEmailSentBoolToItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "ThreshHoldEmailSent", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "ThreshHoldEmailSent");
        }
    }
}
