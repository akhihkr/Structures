using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.RecurseBacktrack._4.CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            N = 4
            arr[] = { 7, 2, 6, 5 }
            B = 16
            Output:
            (2 2 2 2 2 2 2 2)
            (2 2 2 2 2 6)
            (2 2 2 5 5)
            (2 2 5 7)
            (2 2 6 6)
            (2 7 7)
            (5 5 6)
            */

            int[] candidates = { 7, 2, 6, 5 };

            List<IList<int>> result = new List<IList<int>>();
            List<int> combination = new List<int>();
            Array.Sort(candidates);
            CombinationSum(result, candidates, combination, 16, 0);
            
        }

        private static void CombinationSum(IList<IList<int>> result, int[] candidates, IList<int> combination, int target, int start)
        {
            if (target == 0)
            {
                result.Add(new List<int>(combination));
                return;
            }

            for (int i = start; i < candidates.Length && target >= candidates[i]; i++)
            {
                combination.Add(candidates[i]);
                CombinationSum(result, candidates, combination, target - candidates[i], i);
                combination.Remove(candidates[i]);
            }
        }
    }
}
