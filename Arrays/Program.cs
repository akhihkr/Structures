using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------ClassArray----------");

            #region ClassArray
            // The actual code for creating an Array to hold DVD's.
            DVD[] dvdCollection = new DVD[15];

            DVD incrediblesDVD = new DVD("The Incredibles", 2004, "Brad Bird");
            DVD findingDoryDVD = new DVD("Finding Dory", 2016, "Andrew Stanton");
            DVD lionKingDVD = new DVD("The Lion King", 2019, "Jon Favreau");

            // Put "The Incredibles" into the 4th place: index 3.
            dvdCollection[3] = incrediblesDVD;

            // Put "Finding Dory" into the 10th place: index 9.
            dvdCollection[9] = findingDoryDVD;

            // Put "The Lion King" into the 3rd place: index 2.
            dvdCollection[2] = lionKingDVD;

            DVD starWarsDVD = new DVD("Star Wars", 1977, "George Lucas");
            dvdCollection[3] = starWarsDVD;

            // Print out what's in indexes 7, 10, and 3.
            Console.WriteLine(dvdCollection[3].ToString());
            Console.WriteLine(dvdCollection[9].ToString());
            Console.WriteLine(dvdCollection[2].ToString());
            #endregion


            Console.WriteLine("-----LoopingInArrays------------");


            #region LoopingInArrays

            int[] squareNumbers = new int[10];
            // Go through each of the Array indexes, from 0 to 9.
            for (int i = 0; i < 10; i++)
            {
                // We need to be careful with the 0-indexing. The next square number
                // is given by (i + 1) * (i + 1).
                // Calculate it and insert it into the Array at index i.
                int square = (i + 1) * (i + 1);
                squareNumbers[i] = square;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(squareNumbers[i].ToString());
            }

            Console.WriteLine("--------------------");

            foreach (int i in squareNumbers)
            {
                Console.WriteLine(i.ToString());
            }
            #endregion


            Console.WriteLine("------CapacityLength------------");


            #region CapacityLength

            // Create a new array with a capacity of 6.
            int[] array = new int[6];

            // Current length is 0, because it has 0 elements.
            int length = 0;

            // Add 3 items into it.
            for (int i = 0; i < 3; i++)
            {
                array[i] = i * i;
                // Each time we add an element, the length goes up by one.
                length++;
            }

            Console.WriteLine("The Array has a capacity of " + array.Length);
            Console.WriteLine("The Array has a length of " + length);

            #endregion




            Console.WriteLine("------Find Max Consecutive 1s------------");


            #region MaxConsecutiveOnes

                Console.WriteLine(Finder.findMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }));


            #endregion


            Console.WriteLine("------return Number DIgits------------");

            #region FindEvenNumberDigits

            Console.WriteLine(Finder.FindNumbersDigits(new int[] { 12, 345, 2, 6, 7896 }));

            #endregion

            Console.WriteLine("------Sorted Squares------------");

            #region FindEvenNumberDigits

            Console.WriteLine(Finder.FindNumbersDigits(new int[] { -4, -1, 0, 3, 10 }));

            #endregion


            Console.ReadLine();

        }

    }

    public class Finder
    {
        public static int findMaxConsecutiveOnes(int[] nums)
        {
            int maxConsecutiveOnes = 0;
            int ConsecutiveOnes = 0;

            for(int i=0; i < nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    ConsecutiveOnes++;
                    maxConsecutiveOnes=Math.Max(maxConsecutiveOnes, ConsecutiveOnes);   
                }
                else
                {
                    ConsecutiveOnes = 0;
                }
            }
           
            return maxConsecutiveOnes;

        }

        public static int FindNumbersDigits(int[] nums)
        {
            int countNumberEvenDigits = 0;
            foreach(int num in nums)
            {

                Console.WriteLine(Math.Abs(num));
                Console.WriteLine(Math.Log10(Math.Abs(num)));

                Console.WriteLine(  Math.Floor(Math.Log10(  Math.Abs(num)   )    )  );

                //if(num.ToString().Length%2 == 0)
                if (Math.Floor(Math.Log10(Math.Abs(num)) + 1) % 2 == 0)
                {
                    countNumberEvenDigits++;
                }
            }

            return countNumberEvenDigits;
        }


        public static int[] SortedSquares(int[] nums)
        {
            //squared
            for(int i=0;i<nums.Length;i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            //reordered
            

            return null;
        }
    }


    // A simple definition for a DVD.
    public class DVD
    {
        public string name;
        public int releaseYear;
        public string director;

        public DVD(string name, int releaseYear, string director)
        {
            this.name = name;
            this.releaseYear = releaseYear;
            this.director = director;
        }

        public override string ToString()
        {
            return this.name + ", directed by " + this.director + ", released in " + this.releaseYear;
        }
    }
}
