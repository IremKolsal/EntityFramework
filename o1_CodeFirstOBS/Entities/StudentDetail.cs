using o1_CodeFirstOBS.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o1_CodeFirstOBS.Entities
{
    public class StudentDetail
    {
        [Key]
        [ForeignKey("Student")]
        public int Id { get; set; }

        [StringLength(500, ErrorMessage = "En fazla 500 karakter girilebilir.")]
        public string Adress { get; set; }

        [StringLength(20, ErrorMessage = "En fazla 20 karakter girilebilir.")]
        public string Phone { get; set; }

        [Required]
        public Gender? Gender { get; set; }


        public Student Student { get; set; }
    }
}
