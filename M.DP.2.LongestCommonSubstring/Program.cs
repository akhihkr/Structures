using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.DP._2.LongestCommonSubstring
{
    internal class Program
    {
        public static int LCS =0;
        static void Main(string[] args)
        {
            /*
                Input: S1 = "ABCDGH", S2 = "ACDGHR"
                Output: 4
                Explanation: The longest common substring
                is "CDGH" which has length 4.
            */

        }

        public static int longestCommonSubstr(string S1, string S2, int n, string substring,int i,int j)
        {
            LCS = 0;
            for (int k = 0; k < n; k++)
            {
                if (S1[i] == S2[k])
                {
                    LCS++;
                    break;
                }
            }


        }
    }
}
