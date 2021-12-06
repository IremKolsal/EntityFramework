using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o1_CodeFirstOBS.Entities
{
    public class Faculty : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }


        public List<Department> Departments { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
