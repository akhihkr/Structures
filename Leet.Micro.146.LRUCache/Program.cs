using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet.Micro._146.LRUCache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            //["LRUCache", "put", "put", "get", "put", "get", "put", "get", "get", "get"]
            //[[2], [1, 1], [2, 2], [1], [3, 3], [2], [4, 4], [1], [3], [4]]
            //Output
            //[null, null, null, 1, null, -1, null, -1, 3, 4]

            LRUCache lRUCache = new LRUCache(2);
            Console.Write( lRUCache.Put(1, 1)); // cache is {1=1}
            Console.Write(",");
            Console.Write(lRUCache.Put(2, 2)); // cache is {1=1, 2=2}
            Console.Write(",");
            Console.Write( lRUCache.Get(1));    // return 1
            Console.Write(",");
            Console.Write( lRUCache.Put(3, 3)); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
            Console.Write(",");
            Console.Write(lRUCache.Get(2));    // returns -1 (not found)
            Console.Write(",");
            Console.Write(lRUCache.Put(4, 4)); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
            Console.Write(",");
            Console.Write( lRUCache.Get(1));    // return -1 (not found)
            Console.Write(",");
            Console.Write( lRUCache.Get(3));    // return 3
            Console.Write(",");
            Console.Write( lRUCache.Get(4));    // return 4
            Console.Write(",");


            Console.ReadLine();
        }
    }

    public class LRUCache
    {
        public LinkedList<int[]> list;
        Dictionary<int, LinkedListNode<int[]>> dictCache;
        int capacity;

        public LRUCache(int capacity)
        {
            this.list = new LinkedList<int[]>();
            this.dictCache = new Dictionary<int, LinkedListNode<int[]>>();
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            if (dictCache.ContainsKey(key))
            {
                int tempVal = dictCache[key].Value[1];

                list.Remove(dictCache[key]);
                dictCache.Remove(key);

                dictCache.Add(key, list.AddFirst(new int[] { key, tempVal }));

                return dictCache[key].Value[1];
            }
            else
                return -1;
        }

        public string Put(int key, int value)
        {
            if(dictCache.ContainsKey(key))
            {
                list.Remove(dictCache[key]);
                dictCache.Remove(key);
            }
            if (dictCache.Count>=capacity)
            {
                dictCache.Remove(list.Last.Value[0]);
                list.RemoveLast();
            }

            dictCache.Add(key,list.AddFirst(new int[] { key, value }));

            return null;
        }
    }
}
