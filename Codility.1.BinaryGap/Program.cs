using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._1.BinaryGap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(1162));
        }

        public static int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int maxGap = 0;
            string binaryNum = Convert.ToString(N, 2);
            int numLength = binaryNum.Length;
            bool counting = false;
            int count = 0;
            //traverse
            for (int i = 0; i < numLength; i++)
            {
                if (!counting && binaryNum[i] == '1')
                {
                    counting = true;
                }
                else if (counting && binaryNum[i] == '1')
                {
                    //counting = false;
                    maxGap = Math.Max(maxGap, count);
                    count = 0;

                }
                if ((counting && binaryNum[i] == '0'))
                {
                    count++;
                }
            }

            return maxGap;
        }
    }
}
