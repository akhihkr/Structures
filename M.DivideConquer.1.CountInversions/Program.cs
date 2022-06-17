using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.DivideConquer._1.CountInversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] arr = { 2, 4, 1, 3, 5 };
            long N=5;
            long res = inversionCount( arr,  N);
        }

        // arr[]: Input Array
        // N : Size of the Array arr[]
        // Function to count inversions in the array.
        public static long inversionCount(long[] arr, long N)
        {
            //your code here
            int swapCounts = 0;
            //find least number
            Dictionary<long, long> currentMinSwapValue = new Dictionary<long, long>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                long minValue = long.MaxValue;
                long maxValueIndex = -1;
                findMinValueIndex(arr, i, ref minValue,ref  maxValueIndex);

                //swap prev to current min i
                while (maxValueIndex >i)
                {
                    swapXY(arr, maxValueIndex - 1, maxValueIndex);
                    swapCounts++;
                    maxValueIndex--;
                }
            }

            return swapCounts;
        }

        public static void swapXY(long[] arr, long prev, long next)
        {
            long temp = arr[prev];
            arr[prev] = arr[next];
            arr[next] = temp;
        }

        public static void findMinValueIndex(long[] arr, long start, ref long minValue, ref long minValueIndex)
        {

            for (long i = start; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    minValueIndex = i;
                }
            }
        }
    }
}

