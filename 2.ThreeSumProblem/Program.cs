using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ThreeSumProblem
{
    internal class Program
    {
        //Input: 
        //[-3, -1, 1, 0, 2, 10, -2, 8]

        //Output: 
        //[
        // [-3, 1, 2],
        // [-2, 0, 2],
        // [-1, 0, 1]
        //]

        static void Main(string[] args)
        {
            //int[] arrayParam = { -3, -1, 1, 0, 2, 10, -2, 8 };
            int[] arrayParam = { 0, 2, 0, 2, 0, 0, 3, 1, -3, 3, 0, -3, 2, 2, -1, 4, 2, -4, 3, 0, -4, 2, 2, -3, 1, 4, 0, 3, 1, -2, 1, 3, -4, 4, 2, -4, 4, 0, -3, 2 };

            var result = threeSum(arrayParam);

        }

        public static List<List<int>> threeSum(int[] nums)
        {
            Array.Sort(nums);

            //to avoid duplicates
            HashSet<List<int>> result = new HashSet<List<int>>();

            //move root until last -2 as 3 sum
            for (int root = 0; root < nums.Length - 2; root++)
            {
                if (root != 0 && nums[root] == nums[root - 1]) continue;
                twoSum(root, nums, result);
                

            }

            return result.ToList();

        }

        public static void twoSum(int root, int[] A, HashSet<List<int>> result)
        {
          
            //search space reduce
            int low = root + 1;
            int high = A.Length-1;

            while(low< high)
            {
                int totalThreeSum = A[root] + A[low] + A[high];

                if(totalThreeSum == 0)
                {
                    
                    result.Add(new List<int>() { A[root], A[low], A[high] });
                        low++;
                        high--; 
                    while (low < A.Length && A[low] == A[low - 1]) low++;
                    while (high >= 0 && A[high] == A[high + 1]) high--;

                }
                else if (totalThreeSum < 0)
                {
                    low++;
                }
                else
                {
                    high--;
                }

            }


            
        }

        public static void twoSum2(int root, int[] A, HashSet<List<int>> result)
        {

            //search space reduce
            int low = root + 1;
            int high = A.Length - 1;

            while (low < high)
            {
                int totalThreeSum = A[root] + A[low] + A[high];

                if (totalThreeSum == 0)
                {

                    result.Add(new List<int>() { A[root], A[low], A[high] });
                    low++;
                    high--;
                    while (low < A.Length && A[low] == A[low - 1]) low++;
                    while (high >= 0 && A[high] == A[high + 1]) high--;

                }
                else if (totalThreeSum < 0)
                {
                    low++;
                }
                else
                {
                    high--;
                }

            }



        }






    }
}
