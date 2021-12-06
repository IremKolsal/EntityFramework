namespace k2_CodeFirstWithMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryAndProductChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Categories", "Description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String());
            AlterColumn("dbo.Categories", "Description", c => c.String());
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
        }
    }
}
