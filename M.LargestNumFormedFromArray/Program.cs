using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.LargestNumFormedFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            List<int> arr = new List<int> (){ 3, 30, 34, 5, 9 };

            Solution sln = new Solution();
            Console.WriteLine(sln.printLargest(arr));
        }

    }
    public class Solution
    {

        public string printLargest(List<int> arr)
        {
            string output="";

            if(arr is null || arr.Count <= 0)
                return output;

            // code here
            //for (int i = 0; i < arr.Count - 1; i++)
            //{

            //    string element = arr[i].ToString();
            //    string nextElement = arr[i + 1].ToString();

            //}
            //List<string> newList = arr.ConvertAll<string>(delegate (int i) { return i.ToString(); });

            arr.Sort(MyCompare);

            for (int i = 0; i < arr.Count; i++)
            {
                output = output + arr[i];
            }

            if (output[0] == '0' && output.Length > 1)
            {
                Console.Write("0");
            }
            return(output);
        }
        public static int MyCompare(int X, int Y)
        {
            // first append Y at the end of X
            string XY = X.ToString() + Y.ToString();

            // then append X at the end of Y
            string YX = Y.ToString() + X.ToString();

            // Now see which of the two
            // formed numbers is greater
            return XY.CompareTo(YX) > 0 ? -1 : 1;
        }


    }



}
