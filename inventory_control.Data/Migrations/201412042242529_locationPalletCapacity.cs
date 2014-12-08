namespace inventory_control.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locationPalletCapacity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "PalletCapacity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "PalletCapacity");
        }
    }
}
