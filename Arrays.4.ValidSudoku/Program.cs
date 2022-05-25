using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays._4.ValidSudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public bool validSudoku(int[][] board)
        {

            bool isValid = true;

            //define a map to save existing locations as reference
            HashSet<string> valuesMapped = new HashSet<string>();

            //loop for each row col
            for(int row = 0; row < board.Length; row++)
            {
                for(int col = 0; col < board[row].Length; col++)
                {
                    //ignore zeros
                    if(board[row][col] != 0)
                    {
                        //mark current row
                        string currentRow = row.ToString() + "(" + board[row][col] + ")";
                        //mark current col
                        string currentCol = "(" + board[row][col] + ")" + col.ToString();
                        //mark current grid
                        string currentGrid = (row / 3).ToString() + "(" + board[row][col] + ")" + (col / 3).ToString();

                        //check if exists return false now itself 
                        if (valuesMapped.Contains(currentRow) || valuesMapped.Contains(currentCol) || valuesMapped.Contains(currentGrid))
                        {
                            isValid = false;
                            return isValid;
                        }

                        //else add to map
                        valuesMapped.Add(currentRow);
                        valuesMapped.Add(currentCol);
                        valuesMapped.Add(currentGrid);
                    }
                    
                }
            }


            return isValid;
        }

    }
}
