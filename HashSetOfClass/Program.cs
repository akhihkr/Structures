using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetOfClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,List<int>> dictValues = new Dictionary<string,List<int>>();  

           int[] arrary1= new int[] {1,2,3 };
           int[] arrary2 = new int[] { 1, 2, 3 };
           int[] arrary3 = new int[] { 4, 5, 6 };

            dictValues.Add(string.Join("",arrary1), arrary1.ToList());
            if (!dictValues.ContainsKey(string.Join("", arrary2)))
            { dictValues.Add(string.Join("", arrary2), arrary1.ToList()); }
            dictValues.Add(string.Join("", arrary3), arrary1.ToList());

            Console.ReadLine();
        }
    }
}
