using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.DP._4.LongestPalindromicSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Input: s = "bbbab"
            Output: 4
            Explanation: One possible longest palindromic subsequence is "bbbb".
            */
            int[,] memo = new int[5, 5];
            Console.WriteLine(LongestPalindromeSubseq("bbbab", 0, 4,memo));

            Console.ReadLine();
        }

        public static int LongestPalindromeSubseq(string s, int i, int j, int[,] memo)
        {
            //base case
            if (i > j  )
                return 0;
            if (i == j)
                return 1;


            //logic equals
            if (s[i] == s[j])
            {
                memo[i,j] = 2+ LongestPalindromeSubseq(s, i + 1, j - 1, memo);
            }
            else
            {
                memo[i, j] = Math.Max(
                                     LongestPalindromeSubseq(s, i, j - 1, memo),
                                      LongestPalindromeSubseq(s, i + 1, j, memo)
                                    );
            }

            return memo[i, j];

        }
    }
}
