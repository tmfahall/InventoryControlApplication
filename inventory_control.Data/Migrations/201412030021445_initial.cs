namespace inventory_control.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: false)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: false)
                .Index(t => t.DepartmentId)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        OrderQuantity = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                        DepartmentId = c.Int(nullable: false),
                        IsComplete = c.Boolean(nullable: false),
                        BeginTimestamp = c.DateTime(nullable: false),
                        CompleteTimestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: false)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: false)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: false)
                .Index(t => t.ItemId)
                .Index(t => t.UserId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        MinQuantity = c.Int(nullable: false),
                        MaxQuantity = c.Int(nullable: false),
                        QuantityPerPallet = c.Int(nullable: false),
                        QuantityInStock = c.Int(nullable: false),
                        SupplierPartId = c.Int(nullable: false),
                        BarCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: false)
                .ForeignKey("dbo.SupplierParts", t => t.SupplierPartId, cascadeDelete: false)
                .Index(t => t.SupplierId)
                .Index(t => t.SupplierPartId);
            
            CreateTable(
                "dbo.ItemLocationXrefs",
                c => new
                    {
                        ItemLocationXrefId = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        QuantityOnPallet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemLocationXrefId)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: false)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: false)
                .Index(t => t.ItemId)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            CreateTable(
                "dbo.SupplierParts",
                c => new
                    {
                        SupplierPartId = c.Int(nullable: false, identity: true),
                        SupplierPartName = c.String(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierPartId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: false)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Orders", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "SupplierPartId", "dbo.SupplierParts");
            DropForeignKey("dbo.Items", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.SupplierParts", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.ItemLocationXrefs", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.ItemLocationXrefs", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Orders", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Orders", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.SupplierParts", new[] { "SupplierId" });
            DropIndex("dbo.ItemLocationXrefs", new[] { "LocationId" });
            DropIndex("dbo.ItemLocationXrefs", new[] { "ItemId" });
            DropIndex("dbo.Items", new[] { "SupplierPartId" });
            DropIndex("dbo.Items", new[] { "SupplierId" });
            DropIndex("dbo.Orders", new[] { "DepartmentId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.Orders", new[] { "ItemId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUsers", new[] { "DepartmentId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.SupplierParts");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Locations");
            DropTable("dbo.ItemLocationXrefs");
            DropTable("dbo.Items");
            DropTable("dbo.Orders");
            DropTable("dbo.Departments");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}
