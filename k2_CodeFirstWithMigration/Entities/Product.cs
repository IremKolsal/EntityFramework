using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigration.Entities
{
    public class Product: BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }


        public decimal UnitPrice { get; set; }


        public int CategoryId { get; set; }//n-1 ilişki //bir productın bir kategorisi olmak zorunda değil int?
        public Category Category { get; set; } //çoğul olarak(join) yazmak, include yapabilmemiz için geçerli 

    }
}
