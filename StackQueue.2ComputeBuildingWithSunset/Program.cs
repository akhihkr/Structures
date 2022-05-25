using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue._2ComputeBuildingWithSunset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] buildings = new int[] { 7,4,8,2,9 };
            List<int> res = getBuildingsWithAView(buildings);
        }

        public static List<int> getBuildingsWithAView(int[] buildings)
        {
            Stack<int> stackBuilding = new Stack<int>();

            if(buildings.Length<1)
            {
                return new List<int>() { 0 };
            }


            for (int i=buildings.Length-1; i>=0; i--)   
            {
                
                    while(stackBuilding.Count>0 && buildings[i] >= buildings[stackBuilding.Peek()])
                    { 
                        stackBuilding.Pop();
                    }
                    stackBuilding.Push(i);
                
            }

            return stackBuilding.ToList();

        }
    }
}
