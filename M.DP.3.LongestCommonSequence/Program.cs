using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.DP._3.LongestCommonSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonSubsequence( "abcde",  "ace"));

        }
        public static int LongestCommonSubsequence(string text1, string text2)
        {

            return LCSRecurse(text1, text2, text1.Length - 1, text2.Length - 1);

        }

        public static int LCSRecurse(string text1, string text2, int i, int j)
        {
            //Base Case
            if (i < 0 || j < 0)
            {
                return 0;
            }


            //logic decision
            if (text1[i] == text2[j]) //same move both pointer to left
            {
                return 1 + LCSRecurse(text1, text2, i-1, j-1);
            }
            //Max from left right decision
            return Math.Max(
                            LCSRecurse(text1, text2, i, j-1),
                            LCSRecurse(text1, text2, i-1, j)
                        );
           



        }
    }
}
