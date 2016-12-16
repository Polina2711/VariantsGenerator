using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StateExamVariants
{
    public class VariantGenerator: IVariantGenerator
    {

        public event Func<int, string[]> GetTaskProblem;

        public static Dictionary<int, List<string[]>> dict = new Dictionary<int, List<string[]>>();
        Random r = new Random();

        public void Generator(int tasknum, int numboftasks)
        {
            List<string[]> onetask = new List<string[]>();
            while (numboftasks != 0)
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Stream stream = assembly.GetManifestResourceStream("StateExamVariants.AL.Task" + tasknum + ".txt");
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                List<string> tasknumbers = new List<string>();
                string taskn;
                while ((taskn = reader.ReadLine()) != null)
                {
                    tasknumbers.Add(taskn);
                }
                reader.Close();

                string[] result = GetTaskProblem?.Invoke(int.Parse(tasknumbers[(r.Next(tasknumbers.Count))]));
                onetask.Add(result);

                numboftasks--;
            }
            dict.Add(tasknum, onetask);
        }

        public Dictionary<int, List<string[]>> GetDict()
        {
            return dict;
        }

        public List<string[]> GetValueByKeyFromDict(int taskid)
        {
            List<string[]> result = new List<string[]>();
            var check = dict.TryGetValue(taskid, out result);
            return result;
        }

        public void ClearDict()
        {
            dict.Clear();
        }
    }
}
