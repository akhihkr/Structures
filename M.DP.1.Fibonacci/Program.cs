using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.DP._1.Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = 7;
            int[] memo = new int[n+1];
            
            for (int i = 0; i <=n; i++)
            {
                memo[i] = -1;
            }
            Console.WriteLine( fibonnaci(n,memo));

        }

        static int fibonnaci(int n, int[] memo)
        {
           
            if(memo[n]==-1)
            {
                int res;
                if (n == 0 || n == 1)
                    return n;

                res =  fibonnaci(n-1,memo) + fibonnaci(n-2, memo);

                memo[n] = res;
            }

            return memo[n];
        }


    }
}
