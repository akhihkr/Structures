using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queueTest = new Queue<int>();
            queueTest.Enqueue(1);
            queueTest.Enqueue(2);
            queueTest.Enqueue(3);
            queueTest.Enqueue(4);
            queueTest.Enqueue(5);

            foreach(var item in queueTest)
            {
                Console.WriteLine("{0} _ ",item);
            }

            Console.WriteLine("Peek first{0} ",queueTest.Peek());

            queueTest.Dequeue();

            Console.WriteLine("Dequeue {0} ", queueTest.Peek());


            Console.ReadLine();
        }
    }
}
