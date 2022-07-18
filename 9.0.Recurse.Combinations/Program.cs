using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._0.Recurse.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5,2,1 };
            List<int> combi = new List<int>();
            List<List<int>> combis = new List<List<int>>();

            combiGenerator(nums, 3, combi, combis);

        }

        static void combiGenerator(int[] nums, int index, List<int> combo, List<List<int>> combos)
        {
            // base case
            if (index == 0)
            {
                List<int> list = new List<int>();
                foreach (int i in combo)
                {
                    list.Add(i);
                }
                combos.Add(list);
                return;
            }

            combo.Add(nums[index-1]);
            combiGenerator( nums, index - 1, combo,combos);
            combo.RemoveAt(combo.Count-1);
            combiGenerator(nums, index - 1, combo, combos);

        }
    }
}
