using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExamVariants
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        public int ExNumber { get; set; }
        [StringLength(100)]
        [System.ComponentModel.DataAnnotations.Schema.Index(IsUnique = true)]
        public string Level { get; set; }
        public string Task { get; set; }
        public string Solution { get; set; }
        public string Answer { get; set; }

        
    }
}
