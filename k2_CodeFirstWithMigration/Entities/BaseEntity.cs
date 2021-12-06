using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigration.Entities
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

        /*
         struct(value type): nullable değillerdir. int, bool, datetime, double, decimal..
        referance type: string, class, nullable tiplerdir.
         */

    }
}
