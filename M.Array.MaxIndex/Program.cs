using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Array.MaxIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<int> arr = new List<int>() { 70, 83, 82, 39, 81 };
             List<int> arr = new List<int>() { 15, 86, 78, 93, 100,6 };

            Solution obj = new Solution();
            int res = obj.maxIndexDiff(arr.ToArray(), 6);
            Console.WriteLine(res);
        }
    }

    class Solution
    {

        public int maxIndexDiff(int[] A, int N)
        {

            int maxIndex = -1;
            //edge
            if (N <= 0)
                return maxIndex;

            //calc LeftMin
            int[] lMin = new int[N];
            lMin[0]=A[0];
            for(int i = 1; i < N; i++)
            {
                lMin[i]=Math.Min(A[i],lMin[i-1]);
            }

            //calc rightMin
            int[] rMax = new int[N];
            rMax[N-1] = A[N-1];
            for (int i = N-2; i >=0; i--)
            {
                rMax[i] = Math.Max(A[i], rMax[i+1]);
            }

            int iLeft = 0;
            int iRight = 0; 
            while(iLeft<N && iRight<N)
            {

                if(lMin[iLeft]<=rMax[iRight])
                {
                    maxIndex = Math.Max(maxIndex, iRight - iLeft);
                    iRight++;
                }
                else
                {
                    iLeft++;
                }

            }

            return maxIndex;
        }

    }
}

