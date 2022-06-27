using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Graph._1.WordLadder
{
    internal class Program
    {
        public static Dictionary<string,List<string>> adjacencyWords = new Dictionary<string, List<string>>();
        static void Main(string[] args)
        {
            /*
            Input: beginWord = "hit", endWord = "cog", wordList = ["hot", "dot", "dog", "lot", "log", "cog"]
            Output: 5
            Explanation: One shortest transformation sequence is "hit"-> "hot"-> "dot"-> "dog"->cog", which is 5 words long.
            */

            List<string> wordList = new List<string>(){ "hot", "dot", "dog", "lot", "log", "cog"};
            string beginWord = "hit";
            string endWord = "cog";

           

            LadderLength(beginWord, endWord, wordList);
        }

        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            //check if beginword exist in wordList  O(n)
            bool foundBegin=false;
            bool foundEnd=false;
            for (int i = 0; i < wordList.Count; i++)
            {
                if(beginWord.Equals(wordList[i]))
                {
                    foundBegin=true;
                }
                if (endWord.Equals(wordList[i]))
                {
                    foundEnd = true;
                }
            }

            if(!foundEnd)//return 0 no path possible
            {
                return 0;
            }
            if(!foundBegin)//add to wordlist
            {
                wordList.Add(beginWord);
            }

            //build list adjacency
            buildAdjacencyList(wordList);

            //DFS count to find path


            return 1;
        }

        public static void buildAdjacencyList(IList<string> wordList)//------------ O( N^2 * M )
        {
            for (int i = 0; i < wordList.Count; i++)//..............O(N)
            {
                string source = wordList[i];

                for (int k = 0; k < wordList.Count; k++)//..............O(N)
                {
                    string target = wordList[k];

                    //compare characters
                    int countDiff = 0;
                    for (int j = 0; j < source.Length; j++)//...................O(M)
                    {
                        if (source[j] != target[j])
                        {
                            countDiff++;
                        }
                    }
                    if (countDiff == 1)
                    {
                        //add non directed edge
                        addEdge(source, wordList[i]);
                    }
                }
            }
        }

        public static void addEdge(string u , string v)
        {
            adjacencyWords[u].Add(v);
            adjacencyWords[v].Add(u);
        }

    }
}
