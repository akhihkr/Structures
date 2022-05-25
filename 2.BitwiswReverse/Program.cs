using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BitwiswReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value10 = 10;
            Console.WriteLine(value10);
            Console.WriteLine("value10 {0}", reverseBits(value10));


            int value9090 = 9090;
            Console.WriteLine(value9090);
            Console.WriteLine("value9090 {0}", reverseBits(value9090)); ;

            Console.ReadLine(); 

        }

        public static int reverseBits(int input)
        {
            ///output as zeros
            int output = 0;

            ///input shift to the right to inspect each element
            ///                 INPUT    |   OUTPUT
            ///               00001010   |   0000000O
            ///                          |   
            ///               00000101   |   000000OO
            ///                              000000O1
            ///                              
            ///               00000010   |   00000O1O
            ///               
            ///               00000001   |   00000O1O
            ///                              0000O1O1
            {
                //always shift output to left then add if 1
                output =    output << 1;

                if ((input & 1) == 1)
                {
                    output = (output | 1);
                }

                input = input >> 1;

            }

            //Console.WriteLine("Output {0}", output >> 1);
            return output;
        }
    }
}
