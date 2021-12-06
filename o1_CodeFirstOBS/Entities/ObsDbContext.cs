using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o1_CodeFirstOBS.Entities
{
    public class ObsDbContext : DbContext
    {
        public ObsDbContext()
        {
            this.Database.Connection.ConnectionString = "Server=MSI\\SQLEXPRESS;Database=ObsDb;Trusted_Connection=True;";
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentDetail> StudentDetails { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StudentLesson> StudentLessons { get; set; }
        public DbSet<TeacherLesson> TeacherLessons { get; set; }
        public DbSet<LessonDepartment> LessonDepartments { get; set; }


        /*
         enable migrations (bu kod sadece ilk migrations klasörünü oluştururken yazılacak)
        add-migration MigrationAdi
        update-database


        update-database -TargetMigration:"migrationAdi" // ef migration revert veya rollback 

         */


    }
}
