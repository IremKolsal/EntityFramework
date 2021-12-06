using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o1_CodeFirstOBS.Entities
{
    public class Department : BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }


        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public List<Student> Students { get; set; }
        public List<LessonDepartment> LessonDepartments { get; set; }

    }
}
