namespace o1_CodeFirstOBS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentDetails", "Phone", c => c.String(maxLength: 20));
            AlterColumn("dbo.Teachers", "Branch", c => c.Int(nullable: false));
            AlterColumn("dbo.Teachers", "Title", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Teachers", "Branch", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.StudentDetails", "Phone", c => c.String(maxLength: 13));
        }
    }
}
