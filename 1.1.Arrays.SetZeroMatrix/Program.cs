using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.Arrays.SetZeroMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[][] arr = { 
                                new int[] { 0, 1, 2, 0 }, 
                                new int[] { 3, 4, 5, 2 }, 
                                new int[] { 1, 3, 1, 5 } 
                           };
            */
            int[][] arr = { new int[] { 1, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 1, 1 } };

            SetZeroes(arr);
            Console.WriteLine("The Final Matrix is ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void SetZeroes(int[][] matrix)
        {

            bool[][] visited = new bool[matrix.Length][];
            for (int k = 0; k < matrix.Length; k++)
            {
                visited[k] = new bool[matrix[0].Length];
            }

            //traverse each one
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {

                    if (matrix[row][col] == 0 && !visited[row][col])
                    {

                        //reset complete col to 0
                        for (int i = 0; i < matrix.Length; i++)
                        {
                            if (matrix[i][col] != 0)
                            {
                                matrix[i][col] = 0;
                                visited[i][col] = true;
                            }
                        }
                        //reset complete row to 0
                        for (int j = 0; j < matrix[0].Length; j++)
                        {
                            if(matrix[row][j] != 0)
                            { 
                                matrix[row][j] = 0;
                                visited[row][j] = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
