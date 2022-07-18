using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2.Arrays.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<IList<int>> rowList = new List<IList<int>>();
            rowList = rowListReturnPascalTriangle(5);
        }

        public static IList<IList<int>> rowListReturnPascalTriangle(int numRows)
        {
            IList<IList<int>>  rowList= new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();
                if (i == 0)
                { row.Add(1); }
                else if (i == 1)
                { row.Add(1); row.Add(1); }
                else
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                            row.Add(1);
                        else if (i > 1 && j < i)
                            row.Add(rowList[i-1][j-1] + rowList[i-1][j]);
                    }
                }
                

                rowList.Add(row);

            }


            return rowList;
        }
    }
}
