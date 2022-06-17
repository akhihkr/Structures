﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.RecurseBacktrack._1.UniquePermutationInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IList<int>> setArray = new List<IList<int>>();

            int[] a = { 1, 2, 3 };
            heapPermutation(a, a.Length, a.Length, setArray);

        }

        // Prints the array
        static void printArr(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        public static void heapPermutation(int[] a, int size, int length, List<IList<int>> setArray)
        {
            if (size == 1)
            {
                printArr(a, length);
                setArray.Add(a.ToList());
            }

            //for each swap permute
            for (int i = 0; i < size; i++)
            {

                heapPermutation(a, size - 1, length, setArray);

                if (size % 2 == 1)//if odd first and last
                {
                    int temp = a[0];
                    a[0] = a[size - 1];
                    a[size - 1] = temp;
                }
                else //if even swap current to last
                {
                    int temp = a[i];
                    a[i] = a[size - 1];
                    a[size - 1] = temp;
                }

            }

        }

    }
}
