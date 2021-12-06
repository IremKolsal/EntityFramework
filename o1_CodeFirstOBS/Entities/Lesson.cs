using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o1_CodeFirstOBS.Entities
{
    public class Lesson : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public List<StudentLesson> StudentLessons { get; set; }
        public List<TeacherLesson> TeacherLessons { get; set; }
        public List<LessonDepartment> LessonDepartments { get; set; }
    }
}
