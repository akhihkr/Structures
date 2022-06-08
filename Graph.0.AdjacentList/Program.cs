using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph._0.AdjacentList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GraphUndirected graphTest = new GraphUndirected(5);
            graphTest.addEdge(0,1);
            graphTest.addEdge(0,2);
            graphTest.addEdge(1,2);
            graphTest.addEdge(1,3);

            graphTest.printGraph();

        }

        /*
            0 - 1 -3
            \   /
              2

            0 | 1 , 2
            1 | 0 , 2 , 3
            2 | 0 , 1
            3 | 1
         */

        public class GraphUndirected
        {
            public List<List<int>> adjacencyList;

            public GraphUndirected(int capacity)
            {
                adjacencyList = new List<List<int>>(capacity);
                for(int i = 0; i < capacity; i++)
                {
                    adjacencyList.Add(new List<int>());
                }
            }

            public void addEdge( int u , int v)
            {
                this.adjacencyList[u].Add(v);
                this.adjacencyList[v].Add(u);
            }
            public void printGraph()
            {
                for(int i = 0; i<adjacencyList.Count;i++)
                {
                    Console.Write(i + " | ");
                    for (int j =0; j<adjacencyList[i].Count;j++)
                    {
                        Console.Write(adjacencyList[i][j]);
                    }
                    Console.WriteLine("\n");
                }
                Console.ReadLine();
            }
        }



        /*
        public class Graph
        {
            public List<List<int>> adjacencyList;
            public Graph(int capacity)
            {
                adjacencyList = new List<List<int>>(capacity);

                for(int i = 0; i < capacity; i++)
                {
                    adjacencyList.Add(new List<int>());
                }
            }

            public void addEdge(List<List<int>> edge , int u,int v)
            {
                edge[u].Add(v);
                edge[v].Add(u);
            }
        }

        Graph graphTest = new Graph(5);
        graphTest.addEdge(graphTest.adjacencyList, 0, 1);
            graphTest.addEdge(graphTest.adjacencyList, 0, 2);
            graphTest.addEdge(graphTest.adjacencyList, 1, 2);
            graphTest.addEdge(graphTest.adjacencyList, 1, 3);

       */
    }
}
