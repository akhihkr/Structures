using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._0AdjacencyListRep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numVerticesCapacity = 5;
            List<List<int>> arrayList = new List<List<int>>(numVerticesCapacity);

            for (int i = 0; i < numVerticesCapacity; i++)
                arrayList.Add(new List<int>());

            addEdge(arrayList,0,1);
            addEdge(arrayList, 1, 0);
            addEdge(arrayList, 1, 2);
            addEdge(arrayList, 1, 3);
            addEdge(arrayList, 2, 1);
            addEdge(arrayList, 2, 1);
            addEdge(arrayList, 3, 1);


        }

        public static void addEdge( List<List<int>> arr, int u , int v)
        {
            arr[u].Add(v);
            arr[v].Add(u);
        }
    }
}
