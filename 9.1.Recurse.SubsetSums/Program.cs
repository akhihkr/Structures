using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1.Recurse.SubsetSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 2, 1 };
            List<int> resultSums = new List<int>();
            cominationSums(nums,0, 3, resultSums);

            comparerAsc compAsc = new comparerAsc();
            resultSums.Sort(compAsc);
        }

        static void cominationSums(int[] nums, int sum,int index,List<int> resultSums)
        {
            //base case
            if(index== 0)
            {
                resultSums.Add(sum);
                return;
            }

            //take num
            cominationSums(nums,  sum + nums[index-1], index-1,resultSums);
            //dont take num
            cominationSums(nums, sum , index-1, resultSums);

        }

        
    }
    public class comparerAsc : Comparer<int>
    {
        public override int Compare(int x, int y)
        {
            if(x<y)
                return -1;
            else if(x>y)
                return 1;
            else
                return 0;
        }
    }
}
