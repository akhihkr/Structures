using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.Arrays.Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> perms = new List<List<int>>();
            List<int> nums = new List<int>() { 1,2,3};
            permutate( 0, nums, perms);
        }

        static void permutate(int index, List<int> nums, List<List<int>> perms)
        {
            // base case
            if(index == nums.Count)
            {
                List<int> tempList = new List<int>();
                for(int i =0; i < nums.Count; i++)
                {
                    tempList.Add(nums[i]);
                }
                perms.Add(tempList);
                return;
            }

            for(int i = index; i < nums.Count; i++)
            {
                swap(nums, index, i);
                permutate(index + 1, nums, perms);
                swap(nums, index, i);
            }
        }

        static void swap(List<int> nums,int x,int y)
        {
            int temp = nums[x];
            nums[x] = nums[y];
            nums[y] = temp;
        }
    }
}
