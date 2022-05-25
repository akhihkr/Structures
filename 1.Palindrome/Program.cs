using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPalindromeOne = 9232;

            Console.WriteLine("{0} is palindrome: {1}", numberPalindromeOne, isPalindrome(numberPalindromeOne));

            int numberPalindromeTwo = 12321;

            Console.WriteLine("{0} is palindrome: {1}", numberPalindromeTwo, isPalindrome(numberPalindromeTwo));

            Console.ReadLine();

        }

        private static bool isPalindrome(int possiblePalindrome)
        {
            //edge -ve not palindorome
            if (possiblePalindrome < 0)
            {
                return false;
            }

            ///find number of digits by log
            double log10NumOfDigits = Math.Log10(possiblePalindrome);
            int numberOfDigits = (int)log10NumOfDigits + 1;
            //mask to find most significant digit
            int mask = (int)Math.Pow(10, numberOfDigits - 1);

            //for each until mid compare last and first
            for(int i = 0; i < numberOfDigits/2; i++)
            {

                int mostSignificantDigit = possiblePalindrome / mask;
                int leastSignificantDigit = possiblePalindrome % 10;

                //compare if palin
                if(mostSignificantDigit != leastSignificantDigit)
                {
                    return false;
                }


                //reset posible palindrome
                possiblePalindrome = possiblePalindrome % mask;
                possiblePalindrome = possiblePalindrome / 10;

                //adjust mask
                mask = mask / 100;
                
            }

            //successfully compared
            return true;
        }

        public static bool isPalindrome2(int x)
        {
            //negative not a palindrome because of - ve sign
            if (x < 0)
            {
                return false;   
            }

            /// use log to find numebr of digits
            double logDigit = Math.Log10(x); 
            int numberOfDigits = ((int)Math.Floor(logDigit)) + 1;
            int mask = (int) Math.Pow(10, numberOfDigits - 1);


            ///for each digit until mid
            for(int i = 0; i < numberOfDigits/2; i++)
            {
                //divide for extreme left
                int mostSignificantDigit = x / mask;

                //modulo for least position on right
                int leastSignificantDigit = x % 10;

                if(mostSignificantDigit != leastSignificantDigit)
                { 
                    return false; 
                }

                x %= mask; //mod get before decimal
                x /= 10; // divide get after decimal
                mask /= 100; //readjust mask 


            }

            return true;
        }
    }

}
