using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Insertion
{
    internal class Program
    {
        public static List<int> SortList(List<int> unsortedList)
        {

            #region InsertionSort

            //for each numbet in list
            for (int i = 0; i < unsortedList.Count; i++)
            {
                //save current index
                int current = i;

                //ignore first one and swap whenver current value <  any previous sorted values 
                while (current > 0 && unsortedList[current] < unsortedList[current - 1])
                {
                    //save current
                    int temp = unsortedList[current];

                    /// Swap
                    //set current value to previous value
                    unsortedList[current] = unsortedList[current - 1];
                    //set previous value to current temp value
                    unsortedList[current - 1] = temp;

                    //reduce counter for previous values
                    current--;
                }

            }

            #endregion

            return unsortedList;
        }

        public static List<string> SplitWords(string s)
        {
            return string.IsNullOrEmpty(s) ? new List<string>() : s.Trim().Split(' ').ToList();
        }

        public static void Main()
        {


            List<int> unsortedList = new List<int>() { 10, 11, 9, 7 ,15,3 };//SplitWords(Console.ReadLine()).Select(int.Parse).ToList();

            Console.WriteLine(String.Join(" ", unsortedList));

            List<int> res = SortList(unsortedList);
            Console.WriteLine(String.Join(" ", res));

            Console .ReadLine();
        }
    }
}
