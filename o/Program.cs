using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Minheap minH = new Minheap(10);
            minH.Insert(3);
            minH.Insert(2);
            minH.Insert(15);
            minH.Insert(20);

        }


    }

    public class Minheap
    {
        public int[] arr;
        public int size;
        public int capacity;

        public Minheap(int capacity)
        {
            arr = new int[capacity];
            size = 0;
            this.capacity = capacity;
        }

        public int left(int idx)
        {
            return 2 * idx +1;
        }
        public int right(int idx)
        {
            return 2 * idx + 2;
        }
        public int parent(int idx)
        {
            return (idx - 1)/2;
        }

        public void Insert(int val)
        {
            if (size == capacity)
            {
                return ;
            }
            size++;
            arr[size-1] = val;
            for(int i=size-1; i>0 && arr[parent(i)] >arr[i];)
            {
                swap(i, parent(i));
                i = parent(i);
                //int temp = arr[i];
                //arr[i] = arr[parent(i)];
                //arr[parent(i)] = temp;
                //i = parent(i);

            }
        }
        public void swap(int i , int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
