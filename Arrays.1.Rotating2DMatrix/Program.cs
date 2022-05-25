using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays._1.Rotating2DMatrix
{
    //Given a two-dimensional square matrix(n x n),
    //rotate the matrix 90 degrees to the right(clockwise). 

    //Example 1:
    //Input:
    //[
    //[ 1,  2,  3, 4],
    //[ 5,  6,  7, 8],
    //[ 9, 10, 11, 12],
    //[13, 14, 15, 16]
    //],

    //Output:
    //[
    //[13,  9, 5, 1],
    //[14, 10, 6, 2],
    //[15, 11, 7, 3],
    //[16, 12, 8, 4]
    //]

    // ax0,y0 | bx0,y1 | cx0,y2
    // dx1,y0 | ex1,y1 | fx1,y2
    // gx2,y0 | hx2,y1 | ix2,y2


    // gx0,y0 | dx0,y1 | ax0,y2
    // hx1,y0 | ex1,y1 | bx1,y2
    // ix2,y0 | fx2,y1 | cx2,y2

    //(0,0) -> (0,4) ; (0,1) -> (1,4) ; (0,1) -> (1,4) ; (0,1) -> (1,4) ; 
    //

    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] matrix = new int[3][];
            matrix[0] = new int[3] { 1, 2, 3};
            matrix[1] = new int[3] { 4, 5, 6 };
            matrix[2] = new int[3] { 7, 8, 9 };

            rotateLayers(matrix);


            Console.ReadLine();


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[][] rotateLayers(int[][] matrix)
        {
            //number of layers to travel    
            int numOfLayers = matrix.Length / 2;
            //size of matrix
            int sizeMatrix = matrix.Length - 1;

            //for each layer until num layers
            for(int layer = 0; layer < numOfLayers; layer++)
            {
                //now we walk along the 4 edges
                for(int i=layer; i < sizeMatrix - layer; i++)
                {
                    //save all 4 edge routes
                    int top = matrix[layer][i];
                    int right = matrix[i][sizeMatrix-layer];
                    int bottom = matrix[sizeMatrix - layer][sizeMatrix-i];
                    int left = matrix[sizeMatrix-i][layer];


                    //swap 90 degree
                    matrix[layer][i] = left;
                    matrix[i][sizeMatrix - layer] = top;
                    matrix[sizeMatrix - layer][sizeMatrix - i] = right;
                    matrix[sizeMatrix - i][layer] = bottom;

                }
            }

            return matrix;
        }


        public static int[][] rotateHorizontalToVertical(int[][] matrix)
        {
            //create an empty matrix to copy to
            int[][] matrixCopy = new int[matrix.Length][];
            matrixCopy = matrix.Select(a => a.ToArray()).ToArray();

            int rows = matrix.Length;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    //for each row convert to column
                    matrixCopy[j][(matrix[j].Length - 1 - i)] = matrix[i][j];

                }
            }

            for (int i = 0; i < matrixCopy.Length; i++)
            {
                for (int j = 0; j < matrixCopy[i].Length; j++)
                {
                    Console.Write(matrixCopy[i][j]);
                }
                Console.WriteLine("");
            }

            return null;

        }

    }
}
