namespace o1_CodeFirstOBS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        FacultyId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatedById = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .Index(t => t.FacultyId);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatedById = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Tckn = c.String(nullable: false, maxLength: 11),
                        StudentNumber = c.String(nullable: false, maxLength: 12),
                        TeacherId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatedById = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.StudentDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Adress = c.String(maxLength: 500),
                        Phone = c.String(maxLength: 13),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Tckn = c.String(nullable: false, maxLength: 11),
                        Branch = c.String(nullable: false, maxLength: 100),
                        Title = c.String(nullable: false, maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatedById = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LessonDepartments",
                c => new
                    {
                        LessonId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LessonId, t.DepartmentId })
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Lessons", t => t.LessonId, cascadeDelete: true)
                .Index(t => t.LessonId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatedById = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentLessons",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        LessonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentId, t.LessonId })
                .ForeignKey("dbo.Lessons", t => t.LessonId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.LessonId);
            
            CreateTable(
                "dbo.TeacherLessons",
                c => new
                    {
                        TeacherId = c.Int(nullable: false),
                        LessonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeacherId, t.LessonId })
                .ForeignKey("dbo.Lessons", t => t.LessonId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.LessonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherLessons", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.TeacherLessons", "LessonId", "dbo.Lessons");
            DropForeignKey("dbo.StudentLessons", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentLessons", "LessonId", "dbo.Lessons");
            DropForeignKey("dbo.LessonDepartments", "LessonId", "dbo.Lessons");
            DropForeignKey("dbo.LessonDepartments", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Students", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentDetails", "Id", "dbo.Students");
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Departments", "FacultyId", "dbo.Faculties");
            DropIndex("dbo.TeacherLessons", new[] { "LessonId" });
            DropIndex("dbo.TeacherLessons", new[] { "TeacherId" });
            DropIndex("dbo.StudentLessons", new[] { "LessonId" });
            DropIndex("dbo.StudentLessons", new[] { "StudentId" });
            DropIndex("dbo.LessonDepartments", new[] { "DepartmentId" });
            DropIndex("dbo.LessonDepartments", new[] { "LessonId" });
            DropIndex("dbo.StudentDetails", new[] { "Id" });
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropIndex("dbo.Students", new[] { "TeacherId" });
            DropIndex("dbo.Departments", new[] { "FacultyId" });
            DropTable("dbo.TeacherLessons");
            DropTable("dbo.StudentLessons");
            DropTable("dbo.Lessons");
            DropTable("dbo.LessonDepartments");
            DropTable("dbo.Teachers");
            DropTable("dbo.StudentDetails");
            DropTable("dbo.Students");
            DropTable("dbo.Faculties");
            DropTable("dbo.Departments");
        }
    }
}
