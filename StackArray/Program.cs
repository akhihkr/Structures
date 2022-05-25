using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack <int> stack = new Stack<int>();
            stack.Push (1);
            stack.Push (2); 
            stack.Push (3); 
            stack.Push (4); 
            stack.Push (5); 
            stack.Push (6);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Peek ());
            stack.Pop ();
            Console.WriteLine (stack.Peek ());
            Console.ReadLine ();

        }
    }

    class StackA
    {
        private int[] stackArray;
        private int top;

        public StackA()
        {
            stackArray = new int[10];
            top = -1;
        }

        public StackA(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;
        }

        public int Size()
        {
            return top +1;
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            return (top == stackArray.Length-1);
        }


    }


}
