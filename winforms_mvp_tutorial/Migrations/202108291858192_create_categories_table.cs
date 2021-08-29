namespace winforms_mvp_tutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_categories_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(),
                        ProductName = c.String(nullable: false, maxLength: 50),
                        UnitPrice = c.Double(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        GrandTotal = c.Double(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FistName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Tel = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.orders", "ProductId", "dbo.products");
            DropForeignKey("dbo.orders", "CustomerId", "dbo.customers");
            DropForeignKey("dbo.products", "CategoryId", "dbo.categories");
            DropIndex("dbo.orders", new[] { "ProductId" });
            DropIndex("dbo.orders", new[] { "CustomerId" });
            DropIndex("dbo.products", new[] { "CategoryId" });
            DropTable("dbo.customers");
            DropTable("dbo.orders");
            DropTable("dbo.products");
            DropTable("dbo.categories");
        }
    }
}
