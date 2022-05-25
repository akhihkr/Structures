using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings._4.AddBinaryStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input: s1 = "101", s2 = "1"
            //Output: "110"
            //Explanation: In base 10, “101” represents 5, and “1” represents 1.Their sum is 6, which is “110” in binary.

            var result = addBinaryStrings("101", "1");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static string addBinaryStrings(string s1, string s2)
        {
            StringBuilder binaryString = new StringBuilder();

            //sum both most significants bits.
            int ptrS1 = s1.Length-1;
            int ptrS2 = s2.Length-1;

            //used in summing and carry excess
            int carry = 0;
            int sum = 0;

            while(ptrS1 >= 0 || ptrS2 >= 0)
            {
                sum = carry;

                if(ptrS1 >=0)
                {
                    sum += (int)Char.GetNumericValue(s1[ptrS1--]);
                    
                }
                if(ptrS2 >= 0)
                {
                    sum += (int)Char.GetNumericValue(s2[ptrS2--]);

                }

                binaryString.Append(sum%2);
                carry = sum / 2;

            }

            //in case carry exist
            if(carry>0)
                binaryString.Append(carry);

            return new string(binaryString.ToString().Reverse().ToArray());



        }
    }
}
