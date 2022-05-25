using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays._5.PatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "aac", "bbc", "bcb", "yzy" };
            string pattern = "ghg";
            //Output: ["bcb", "yzy"]

            findAndReplacePattern(words, pattern); 
        }

        public static List<string> findAndReplacePattern(string[] words, string pattern)
        {
            List<string> patternFinder = new List<string>();

            string encodedPattern = encodeString( pattern);

            foreach(string word in words)
            {
                if(encodedPattern.Equals(encodeString(word)))
                {
                    patternFinder.Add(word);
                }
            }

            return patternFinder;

            Console.ReadLine();

        }

        public static string encodeString(string word)
        {
            string encodedString = string.Empty;
            Dictionary<char, int> encodedDict = new Dictionary<char,int>();

            //encode each char at first occurence int position
            int i = 0;
            foreach(char c in word)
            {
                if (!encodedDict.ContainsKey(c))
                {
                    encodedDict.Add(c, i++);
                    
                }
                encodedString += encodedDict[c];
            }

            return encodedString;

        }
    }
}
