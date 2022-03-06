using System;

namespace ConsoleApp1._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  5 dene eded verilib.Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5 % tap ,neticeleri vur bir birine.
  Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla. */

            int a = 12345;
            int b = 23456;
            int c = 34567;

            int d = 321;
            int e = 213;

            double q = (a * 5 / 100.0) * (b * 5 / 100.0) * (c * 5 / 100.0);
            double f = (d * 3 / 100.0) + (e * 3 / 100.0);
            double g = (q * 10 / 100.0) + (f * 10 / 100.0);

            Console.WriteLine(g);






        }
    }
}
