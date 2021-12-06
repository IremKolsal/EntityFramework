using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o1_CodeFirstOBS.Entities
{
    public class BaseEntity
    {
        [Required]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedById { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public bool IsActive { get; set; }
    }
}
