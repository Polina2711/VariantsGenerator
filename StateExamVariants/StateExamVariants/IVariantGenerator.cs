using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExamVariants
{
    public interface IVariantGenerator
    {
        event Func<int, string[]> GetTaskProblem;
        void Generator(int tasknum, int numboftasks);
        Dictionary<int, List<string[]>> GetDict();
        List<string[]> GetValueByKeyFromDict(int taskid);
        void ClearDict();
    }
}
