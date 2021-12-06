using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o1_CodeFirstOBS.Entities
{
    public class Student : BaseEntity
    {
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter girilebilir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter girilebilir.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Tckn zorunludur.")]
        [StringLength(11, ErrorMessage = "Tckn 11 haneli olmalıdır.")]
        public string Tckn { get; set; }

        [Required(ErrorMessage = "Okul numarası zorunludur.")]
        [StringLength(12, ErrorMessage = "En fazla 12 karakter girilebilir.")]
        public string StudentNumber { get; set; }


        public StudentDetail StudentDetail { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<StudentLesson> StudentLessons { get; set; }



    }
}
