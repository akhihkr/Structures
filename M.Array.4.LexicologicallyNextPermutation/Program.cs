
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Array._4.LexicologicallyNextPermutation
{
    internal class Program
    {

  
    
        static void Main(string[] args)
        {

            //List<int> arr = new List<int>() { 1, 2, 3, 6, 5, 4 };

            List<int> arr = new List<int>() { 1, 2, 3};

            NextPermutation(arr, 3);

        }

        public static void swap (ref List<int> arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public static List<int> NextPermutation(List<int> arr, int n)
        {
            if(n<=1)
                return arr;

            //find prev < current index start from right
            int i = n-2;
            while(arr[i] > arr[i+1])
            {
                i--;
            }

            //swap
            swap(ref arr, i, n - 1);

            //sort from 9 to n
            arr.Sort(i+1, n - 1 -i, new SortAscHelper());

            return arr;
        }

        private class SortAscHelper : IComparer<int>
        {
            public int Compare(int a, int b)
            {
                if (a > b)
                    return 1;
                if (a < b)
                    return -1;
                else
                    return 0;
            }

        }

        private class SortDscHelper : IComparer<int>
        {
            public int Compare(int a, int b)
            {
                if (a < b)
                    return 1;
                if (a > b)
                    return -1;
                else
                    return 0;
            }

        }

    }
}
