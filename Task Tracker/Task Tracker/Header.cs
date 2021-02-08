using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_Tracker
{
    class Header
    {
        public void GetHeader(int[] longestArray)
        {
            Console.Write("TaskName");
            this.PrintSpacing(8, longestArray[0]);
            Console.Write("Date");
            this.PrintSpacing(4, longestArray[1]);

            Console.Write("Location");
            this.PrintSpacing(8, longestArray[2]);

            Console.Write("Description");

            this.GetLine(longestArray);
            Console.WriteLine();
        }

        public void GetCompletedHeader(int[] longestArray)
        {
            Console.Write("TaskName");
            this.PrintSpacing(8, longestArray[0]);
            Console.Write("Date Completed ");
            this.PrintSpacing(15, longestArray[1]);

            Console.Write("Location");
            this.PrintSpacing(8, longestArray[2]);

            Console.Write("Description");

            this.GetLine(longestArray);
            Console.WriteLine();
        }
        public void PrintSpacing(int current, int longest)
        {
            for (int i = current; i < longest + 3; i++)
                Console.Write(" ");
        }
        public void GetLine(int[] longest)
        {
            Console.WriteLine();
            for (int i = 0; i < longest.Sum()+20; i++)
                Console.Write("_");

        }
    }
}
