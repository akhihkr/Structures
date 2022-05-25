using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings._2.LongestPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("aabbc{0}",longestPalindrome("aabbc"));
            Console.WriteLine("aabbc{0}", longestPalindromeStack("aabbc"));



            Console.WriteLine("abbcccd{0}", longestPalindrome("abbcccd"));
            Console.WriteLine("abbcccd{0}", longestPalindromeStack("abbcccd"));


            Console.WriteLine("xyz{0}", longestPalindrome("xyz"));
            Console.WriteLine("xyz{0}", longestPalindromeStack("xyz"));

            Console.WriteLine("cccc{0}", longestPalindrome("cccc"));
            Console.WriteLine("cccc{0}", longestPalindromeStack("cccc"));

        }

        public static int longestPalindrome(string s)
        {
            int longestPalindromeCount = 0;

            //hash to save chars count occurence
            Dictionary<char,int> mapChars=new Dictionary<char,int>();

            //map char counts 
            foreach(char c in s)
            {
                if(!mapChars.ContainsKey(c))
                {
                    mapChars.Add(c, 1);
                }
                else
                {
                    mapChars[c]= mapChars[c]+1;
                }
            }

            //palindrome can contains only 1 odd so save longest odd and add all even
            int largestOddKeyCount =0;
            char? largestOddKeyChar=null;
            foreach (char key in mapChars.Keys)
            {
                if (mapChars[key] % 2 != 0)
                {
                    if(mapChars[key]> largestOddKeyCount)
                    {
                        largestOddKeyCount = mapChars[key];
                        largestOddKeyChar = key;
                    }
                }
                else
                {
                    longestPalindromeCount += mapChars[key];
                }
            }

            //add longest odd
            if (largestOddKeyChar != null)
            {
                longestPalindromeCount += largestOddKeyCount;
                mapChars.Remove((char)largestOddKeyChar);
            }
            

            //add even for all other odds
            foreach(char key in mapChars.Keys)
            {
                if(mapChars[key]%2 != 0 && mapChars[key]>1)
                {
                    longestPalindromeCount += mapChars[key]-1; //-1 to make even
                }
            }

            return longestPalindromeCount;
        }

        public static int longestPalindromeStack(string s)
        {
            //coutnertimes 2 to ger palindrome count
            int counterTimesTwo = 0;

            //stack to push pull char
            Stack<char> palinStack = new Stack<char>();

            foreach(char c in s)
            {
                if(palinStack.Count>0 && palinStack.Peek()==c)
                {
                    counterTimesTwo++;
                    palinStack.Pop();
                }
                else
                {
                    palinStack.Push(c);
                }
            }

            //times 2 for matching char
            counterTimesTwo *= 2;

            //add 1 odd in the middle of stack
            if (palinStack.Count > 0)
            {
                counterTimesTwo+= 1;
            }

            return counterTimesTwo;
        }

        public static int longestPalindromeSet(string s)
        {
            int counterToDoubleMatch = 0;

            HashSet<char> palinSet = new HashSet<char>();

            foreach (char c in s)
            {
                if (palinSet.Contains(c))
                {
                    counterToDoubleMatch++;
                    palinSet.Remove(c);
                }
                else
                {
                    palinSet.Add(c);
                }

            }

            //doubles to adjust matching
            counterToDoubleMatch = counterToDoubleMatch * 2;

            //add remaining odd to palindrome
            if (palinSet.Count > 0)
            {
                counterToDoubleMatch++;
            }

            return counterToDoubleMatch;

        }
    }
}
