using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings._6.ReplaceWordsPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(replaceWordsWithPrefix(new string[] { "cat", "catch", "Alabama" }, "The cats were catching yarn"));
        }

        public static string replaceWordsWithPrefix(string[] prefixes, string sentence)
        { 

            HashSet<string> prefixSet= new HashSet<string>();
            string[] words = sentence.Split(' ');
            
            for(int i=0;i<prefixes.Length;i++)
            {
                prefixSet.Add(prefixes[i]);
            }
             
            for(int i = 0; i < words.Length; i++)
            {
                string word = "";

                //for each letter of word check exist in Set to get min prefix and exit on found
                for(int j = 0; j < words[i].Length; j++)
                {
                    word += words[i][j];
                    if (prefixSet.Contains(word))
                    {
                        words[i] = word;
                        break;
                    }
                }
            }

            return string.Join(" ", words);
        
        }

            public static string replaceWordsWithPrefixWrong(string[] prefixes, string sentence)
        {
            if (sentence.Length <= 0)
                return "";

            string[] sentenceArray = sentence.Split(' ');
            int position = 0;
            foreach (string word in sentenceArray)
            {
                int minPrefix = int.MaxValue; 
                foreach(string prefix in prefixes)
                {
                    if (word.Contains(prefix)&& prefix.Length < minPrefix)
                    {
                        sentenceArray[position] = prefix;
                        minPrefix = prefix.Length;
                    }
                    
                }

                position++;
            }

            return string.Join(" ",sentenceArray) ;
        }
    }
}
