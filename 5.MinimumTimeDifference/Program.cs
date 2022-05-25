using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MinimumTimeDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input: ["00:03", "23:59", "12:03"]
            //Output: 4
            //Input: The closest 2 times are "00:03" and "23:59"(by wrap - around), and they differ by 4 minutes.

            List<string> list = new List<string>() { "00:03", "23:59", "12:03" };

            Console.WriteLine(minTimeDifference(list));

            Console.ReadLine();

        }

        public static int minTimeDifference(List<string> times)
        {
            //sort times in an array (60*24)
            bool[] timesArraySeen = new bool[(60*24)];


            //map sort in timesarray by converting string "HH:mm" to min
            foreach(string s in times)
            {
                //sorted to time
                timesArraySeen[stringToMinutes(s)]=true;
            }

            int previous = -1;
            int first = -1;
            int minDifference = 60 * 24 + 1;// outside bounds

            for (int i=0; i< 60 * 24;i++)
            {

                //first time
                if (timesArraySeen[i]){
                    if (previous != -1)
                    {
                        minDifference = Math.Min(minDifference, i - previous);
                        previous = i;

                    }
                    else
                    {
                        first = i;
                        previous = i;
                    }
                }
            }

            //edge case
            minDifference = Math.Min(minDifference, (first+(60 * 24))-previous);

            return minDifference;   
        }

        public static int stringToMinutes(string stringTimeHHmm)
        {
            string[] hourMinutesArray = stringTimeHHmm.Split(':');
            int hourMinutes = Convert.ToInt32(hourMinutesArray[0])*60;
            
            return hourMinutes+ Convert.ToInt32(hourMinutesArray[1]);
        }
    }
}
