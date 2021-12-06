using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigration.Entities
{
    public class Category: BaseEntity
    {
        //[StringLength(50, MinimumLength =10)]
        //[MaxLength(50)]
        //[MinLength(10)]


        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public byte[] Picture { get; set; }

        public List<Product> Products { get; set; }

    }
}
