using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._1.Arrays.NextPermutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3 };

            NextPermutation(nums);
        }

        static void swap( int[] nums, int i , int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        static void NextPermutation(int[] nums)
        {
            if (nums.Length <= 0) return;

            int backTraverse = nums.Length-2;
            //find first less than
            while(backTraverse >= 0 && nums[backTraverse+1]<= nums[backTraverse]) backTraverse--;
            if(backTraverse >= 0)
            {
                int nextSwapTraverse = nums.Length - 1;
                
                // find next greater element than brakpoint
                while (nums[nextSwapTraverse] <= nums[backTraverse]) nextSwapTraverse--;
                swap(nums, backTraverse, nextSwapTraverse);

                
            }

            //reverse j+1 until last
            reverse(nums, backTraverse+1, nums.Length - 1);
        }

        static void reverse(int[] nums, int i, int j)
        {
            while(i<j)swap (nums, i++, j--);
        }
    }
}
