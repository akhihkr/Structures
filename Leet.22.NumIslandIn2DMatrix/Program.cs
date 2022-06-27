using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet._200.NumIslandIn2DMatrix
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            /*
                Input: grid = [

                ["1", "1", "1", "1", "0"],
                  ["1","1","0","1","0"],
                  ["1","1","0","0","0"],
                  ["0","0","0","0","0"]
                ]

            
                [["1","1","1","1","0"],["1","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]]
                Output: 1
            */
            char[][] grid = new char[4][]
                            {
                                new char[]{'1', '1', '1', '1', '0'},
                                new char[] { '1', '1', '0', '1', '0'},
                                new char[] { '1', '1', '0', '0', '0' },
                                new char[] { '0', '0', '0', '0', '0' }
                            };

            Console.WriteLine(NumIslands(grid));

        }

        public static int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;

            int m = grid.Length;
            int n = grid[0].Length;
            //default visited grid
            bool[,] visitedGrid = new bool[m, n];
            int islandCount = 0;

            //possible island adjacent connection horizontal and vertical only
            List<int[]> dirs = new List<int[]>()
            {
                new int[]{0,1},// right
                new int[]{0,-1},//left
                new int[]{1,0},//up
                new int[]{-1,0}//down
            };


            //traverse the 2d array 
            //bfs
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    //for each element check if not visited add to queue to process
                    //increment island count
                    if(!visitedGrid[i,j] && grid[i][j] =='1')
                    {
                        BFS(grid, visitedGrid, i, j, dirs);
                        ++islandCount;
                    }
              
                }

            }




            return islandCount;

        }

        public static void BFS(char[][] grid, bool[,] visitedGrid, int row, int col,  List<int[]> dirs)
        {

            int m = grid.Length;
            int n = grid[0].Length;
            Queue<KeyValuePair<int, int>> processQueue = new Queue<KeyValuePair<int, int>>();
            processQueue.Enqueue(new KeyValuePair<int, int>(row, col));

            //process queue until empty
            while (processQueue.Count > 0)
            {
                KeyValuePair<int, int> currentIJ = processQueue.Dequeue();
                //check all adjacent if 1 then enqueue if within range and value =1 and not visited

                foreach (var dir in dirs)
                {
                    int xx = currentIJ.Key + dir[0];
                    int yy = currentIJ.Value + dir[1];
                    if (xx < 0 || xx >= m || yy < 0 || yy >= n || grid[xx][yy] == '0' || visitedGrid[xx, yy]) continue;
                    //if (xx >= 0 && xx < m && yy >= 0 && yy < n && !visitedGrid[xx, yy] && grid[xx][col] == '1')
                    {
                        processQueue.Enqueue(new KeyValuePair<int, int>(xx, yy));
                        visitedGrid[xx, yy] = true;
                    }
                }

            }
        }



    }
}
