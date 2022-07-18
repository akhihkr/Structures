using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._0.Recurse.PowerSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 2, 1 };
            int numsLength = nums.Length;
            //map the bit for 2^N
            uint numSets = (uint)Math.Pow(2, numsLength);

            //store of list
            List<List<int>> numsList = new List<List<int>>();

            //for eachmap loop for each item in array
            for(int i = 0; i < numSets; i++)
            {
                List<int> list = new List<int>();
                //for each item check bit map set to one and display
                for(int j = 0; j < numsLength; j++)
                {
                    //shift bit to N to check if set to 1
                    if((i & (1<<j)) >0)
                        list.Add(nums[j]);

                }
                numsList.Add(list);
            }
        }
    }
}
