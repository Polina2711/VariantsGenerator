using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExamVariants
{
    public interface IPDFWriter
    {
        event Func<Dictionary<int, List<string[]>>> GetAllDict;

        void AddToPDFFile(string filename);
    }
}
