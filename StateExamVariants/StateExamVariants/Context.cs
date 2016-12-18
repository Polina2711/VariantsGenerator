using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExamVariants
{
    class Context:DbContext
    {
        public DbSet<Exercise>Exercises { get; set; }
        public Context() : base("localsql")
        { }
        
    }
}
