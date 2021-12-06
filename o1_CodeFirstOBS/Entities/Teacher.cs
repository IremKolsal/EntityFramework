using o1_CodeFirstOBS.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o1_CodeFirstOBS.Entities
{
    public class Teacher : BaseEntity
    {
        #region Propeties
        [Required]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
        public string Surname { get; set; }

        [Required]
        [StringLength(11)]
        public string Tckn { get; set; }

        public Branch Branch { get; set; }

        public Title Title { get; set; }
        #endregion


        #region Relations
        public List<Student> Students { get; set; }
        public List<TeacherLesson> TeacherLessons { get; set; }
        #endregion



    }
}
