namespace k2_CodeFirstWithMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                        Picture = c.Binary(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatedById = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoryId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatedById = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
