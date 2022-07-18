using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch.NthRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int M = 243;
           
            int res = int.MinValue;
            double eps = 1e-6;

            NormalCall(N, M, res);

        }

        static void BinarySearchNthRoot(int N, int M, int res)
        {
            double low = 1;
            double high = M;

            double  eps = 1e-6;

            //binary stop condition
            while((low-high)>eps)
            {
                // find mid 
                double mid = (low+high)/2.0;

                //seach space left 
                if (multiply(mid,N)== N)
                    low = mid;
                //search space right
                else
                    high = mid;

            }
        }

        private static double multiply(double number, int n)
        {
            double ans = 1.0;
            for (int i = 1; i <= n; i++)
            {
                ans = ans * number;
            }
            return ans;
        }

        static void NormalCall(int N, int M, int res)
        {
            int output = 1;
            while (res <= M)
            {
                N = N * N;
                res = N;
                output++;
            }

            Console.WriteLine("output: {0}", output);
        }
    }
}
