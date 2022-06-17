using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Array.PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 3;
            List<int> arr = new List<int>(){ 1, 2, 4 };

            Console.WriteLine(increment(arr,N));

             N = 1;
            List<int> arr2 = new List<int>() { 9 };

            Console.WriteLine(increment(arr2, N));
        }

        public static List<int> increment(List<int> arr, int N)
        {
            // code here
            int sum, carry = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                sum = carry + arr[i];
                if (i == N - 1) { sum += 1; }

                arr[i] = sum % 10;

                carry = sum / 10;
            }
            if (carry > 0)
                arr.Insert(0, 1);

            return arr;
        }
    }
}
