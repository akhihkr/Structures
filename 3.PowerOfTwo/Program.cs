using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PowerOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
            Console.Write(powerOfTwoBitAnd(4000));
            watch.Stop();
            Console.WriteLine("bit {0}",watch.ElapsedMilliseconds);

            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            Console.Write(powerOfTwoModulo(4000));
            watch2.Stop();
            Console.WriteLine("Modulo {0}",watch2.ElapsedMilliseconds);

            Console.ReadLine(); 
        }

        public static bool powerOfTwoBitAnd(int input)
        {
            //edge 0
            if(input < 0)
            { 
                return false;
            }


            //power of two in binary has only one bit turned ON
            //10 = 2 ; 100 = 4 ; 1000 =6;

            // 10 - > 2 ( current )
            // 01 - > 1 ( previous is inverse map bit )
            //__________ BIT AND
            // 00 
            //---------

            if((input & (input-1)) == 0)
            {
                return true;    
            }
            return false;   

        }
        public static bool powerOfTwoModulo(int input)
        {

            #region Modulo way
            //check pow of two if modulo 2 == 0
            if ((input % 2) == 0 || input == 0)
            {
                return true;
            }
            return false;
            #endregion
        }
    }
}
