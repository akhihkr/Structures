using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1.Greedy.NMeetingsOneRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input:
            //N = 6
            //start[] = { 1, 3, 0, 5, 8, 5 }
            //end[] = { 2, 4, 6, 7, 9, 9 }
            //Output:
            //4
            //Explanation:
            //Maximum four meetings can be held with
            //given start and end timings.
            //The meetings are - (1, 2),(3, 4), (5, 7) and(8, 9)

            int[] start = new int[] { 1, 3, 0, 5, 8, 5 };
            int[] end = new int[] { 2, 4, 6, 7, 9, 9 };

            meeting m = new meeting();
            int res = m.maxMeetings(start, end, 6);

        }
    }

    public class meeting
    {
        public int start;
        public int end;
        public int pos;

        public meeting()
        {

        }
        public meeting(int start, int end, int pos)
        {
            this.start = start;
            this.end = end;
            this.pos = pos;
        }
       

        //Complete this function
        public int maxMeetings(int[] start, int[] end, int n)
        {
            List<meeting> meetList = new List<meeting>();
            for(int i =0;i<n;i++)
            {
                meetList.Add(new meeting(start[i], end[i],i));

            }
            meetingComparer mc = new meetingComparer();
            meetList.Sort(mc);

            List<meeting> meetListToInclude = new List<meeting>();
            meetListToInclude.Add(meetList[0]);
            int endTimeLimit = meetList[0].end;

            for (int j = 1; j<n;j++)
            {
                if (meetList[j].start > endTimeLimit)
                {
                    meetListToInclude.Add(meetList[j]);
                    endTimeLimit = meetList[j].end;
                }
            }

            //Your code here
            return meetListToInclude.Count;
        }
    }

    public class meetingComparer:IComparer<meeting>
    {
        public int Compare(meeting x, meeting y)
        {
            if (x.end < y.end)
                return -1;
            else if (x.end > y.end)
                return 1;
            else if (x.pos < y.pos)
                return -1;
            return 1;
        }
    }
}
