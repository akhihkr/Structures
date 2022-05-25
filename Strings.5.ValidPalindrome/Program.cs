using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings._5.ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Input: s = "Race Car"
            //Output: true
            //Explanation: When we ignore case and only consider alphanumeric characters,
            //the string "Race Car" is equivalent to "racecar," which is a palindrome.
            Console.WriteLine(validPalindrome("Race Car"));
        }

        public static bool validPalindrome(string s)
        {
            //two pointers at start and end 
            int lowPointer = 0;
            int highPointer = s.Length-1;

            while(lowPointer< highPointer)
            {
                //check if is alpha numeric then compare
                while (lowPointer<highPointer && !Char.IsLetterOrDigit(s[lowPointer])) { lowPointer++; }
                while ( highPointer>=0 && !Char.IsLetterOrDigit(s[highPointer])) { highPointer--; }

                if(s[lowPointer].ToString().ToLower() != s[highPointer].ToString().ToLower())
                {
                    return false;
                }

                lowPointer++;
                highPointer--;
            }

            return true;

        }
    }
}
