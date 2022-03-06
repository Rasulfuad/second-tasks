using System;

namespace ConsoleApp1._14
{
    internal class Program
    {
        static void Main(string[] args)
        { /*6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir ve bir eded al.
I neticeden II neticeni cix. Alinan cavabin 10% tap. Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11% tap. */
            
          
            int a = 123456;
            int b = 234567;
            int c = 345678;
            int s = 456789;
            int d = 656621;
            int e = 213845;

            long q = a + b + c + d + e + s;
            long f = a * 1000000 + c;
            double g = (q - f) * 10 / 100.0;
            double h = (g + d + e) * 11 / 100.0;
            

            Console.WriteLine(h);
        }
    }
}
