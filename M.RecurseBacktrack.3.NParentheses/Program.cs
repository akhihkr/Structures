using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.RecurseBacktrack._3.NParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateParenthesis(3);
        }

        public static IList<string> GenerateParenthesis(int n)
        {

            List<string> list = new List<string>();

            backTrack(0, 0, n,"",list); 

            return list;

        }

        public static void backTrack(int openP, int closeP, int n,string s,List<string> list)
        {

            //0. base case stop when openP=closeP=n
            if (openP ==n && closeP ==  n)
            {
                list.Add(s);
                return;
            }
            //1. add open paren when openP< n
            if (openP < n)
            {
                backTrack(openP + 1, closeP, n, s+"{",list);
                
            }
            //2. add close paren when closeP< openP
            if (closeP < openP)
            {
                backTrack(openP , closeP +1, n, s + "}", list);

            }


        }
    }
}
