using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AddStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Input: s1 = "95", s2 = "7"
            //Output: "102"

                Console.WriteLine("(95+9) = {0}",addStrings("95", "9"));

            Console.ReadLine(); 
        }
        public static string addStrings(string s1, string s2)
        {
            //197 - i pointer .length-1 until i>=0
            //+25 - j  pointer .length-1 until j>=0  
            //___
            //  result.append(sum of i +  j + carry )
            //___

            int i = s1.Length-1;
            int j = s2.Length-1;
            string result = "";
            int carry = 0;
            
            while(i >= 0 || j >= 0)
            {
                var sum = carry;
                if (i > -1)
                {
                    sum +=  s1[i] - '0';
                    i--;
                }
                if (j > -1)
                {
                    sum += s2[j] - '0';
                    j--;
                }

                carry = (int)sum / 10;
                result += (sum % 10).ToString();
            }

            if(carry == 1)
            {
                result += carry;
            }
            char[] resArray = result.ToCharArray();
            Array.Reverse(resArray);

            return  (new string(resArray));

        }

    }
}
