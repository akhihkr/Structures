using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.EnumeratePrimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 23;

            var result = enumeratePrimes(n);
        }

        /// Time: O(n ^1.5 )
        /// Space: O(n)
        public static List<int> enumeratePrimes(int n)
        {
            List<int> list = new List<int>();

            //primes >0
            
            if (n < 2)
            {
                return list;
            }


            //Prime are divisible only by itself and 1 only (factor)
            
            for (int i=2; i < n; i++)
            {
                bool isPrime = true;

                int j = 2;

                while (j < i)//(j < i) //we loop until half or // j*j <i instead of square root
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                    j++;
                }

                if (isPrime)
                {
                    list.Add(i);
                }
            }

            return list;
        }

        // The method used is Called Sieve of Eratosthenes 
        // Its Time Complexity is O(n*log(log(n)))

        //mark all next prime multiple as false and continue sameprocess
        //a boolean array set to all false
        // 1 and 1 false
        // start with j*j j+j
        //List<Integer> output = new ArrayList<>();
        ////Declare a Boolean Array for storing if a number is prime or not
        //boolean[] isPrime = new boolean[n];
        //    // Initialize every element of this array as true
        //    for (int i = 0; i<n; i++) {
        //      isPrime[i] = true;
        //    }
        //    // Since 0 and 1 are not prime we declare them false explicitly
        //    isPrime[0] = false;
        //    isPrime[1] = false;

        //    for (int i = 0; i<n; i++) {
        //      // Only check if isPrime[i]==true
        //      if (isPrime[i]) {
        //         // Mark all the factor of (i) as Not Prime
        //        for (int j = i + i; j<n; j += i) {
        //          isPrime[j] = false;
        //        }
        ////Accumulating all the prime numbers in output list
        //output.add(i);
        //      }
        //    }




        //////////////////////
    }
}
