using System;

namespace ConsoleApp1.task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4 dene 5 reqemli eded verilib.Her I ededin ustune III ededi gel.II ededin usutune IV eeddi gel.
Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix. */

            int a = 12345;
            int b = 23456;
            int c = 34567;
            int d = 45678;

            double e = (a + c) * (b + d) - (c * 3 / 100.0);
   
            Console.WriteLine(e);

        }
    }
}
