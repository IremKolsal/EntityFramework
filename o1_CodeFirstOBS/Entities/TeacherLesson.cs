using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o1_CodeFirstOBS.Entities
{
    public class TeacherLesson
    {
        [Key]
        [Column(Order = 0)]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        [Key]
        [Column(Order = 1)]
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }

    }
}
