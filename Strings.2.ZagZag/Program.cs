using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings._2.ZagZag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input:
            //            s = "YELLOWPINK"
            //rows = 4

            //Output: "YPEWILONLK"
            //Explanation: There are 4 rows in the zigzag formatted string.

            //Y P(row 1: "YP")
            //E W I(row 2: "EWI")
            //L O   N(row 3: "LON")
            //L K(row 4: "LK")

            string s = "YELLOWPINK";
            int rows = 4;

            Console.WriteLine(zigzag(s, rows));
        }

        public static string zigzag(string s, int rows)
        {

            //edge case
            if (s.Length <= rows || rows == 1) return s;

            string zigzagResult = "";

            //row 1 : ""
            //row 2 : ""
            //...
            //row n : ""
            List<string> zigZagRows = new List<string>();
            for(int i = 0; i < rows; i++)
            {
                zigZagRows.Add("");
            }

            //going down or up diagonal for zigzag
            bool rowDownwards=false;
            int row =0;

            foreach(char c in s)
            {
                if(row==0)
                    rowDownwards=true;
                if(row==rows-1)
                    rowDownwards=false;

                //add to specific row
                zigZagRows[row] += c;

                if (rowDownwards)
                    row++;
                else
                    row--;
            }

            foreach(string chunk in zigZagRows)
            {
                zigzagResult += chunk;
            } 

            return zigzagResult;
        }   
    }


}
