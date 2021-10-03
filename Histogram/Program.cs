using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < numbers; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < 200)
                {
                    p1++;
                }
                else if (currentNum < 400)
                {
                    p2++;
                }
                else if (currentNum < 600)
                {
                    p3++;
                }
                else if (currentNum < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            double percentConverteP1 = (double) p1 / numbers * 100;
            double percentConverteP2 = (double) p2 / numbers * 100;
            double percentConverteP3 = (double) p3 / numbers * 100;
            double percentConverteP4 = (double) p4 / numbers * 100;
            double percentConverteP5 = (double) p5 / numbers * 100;

            Console.WriteLine($"{percentConverteP1:f2}%");
            Console.WriteLine($"{percentConverteP2:f2}%");
            Console.WriteLine($"{percentConverteP3:f2}%");
            Console.WriteLine($"{percentConverteP4:f2}%");
            Console.WriteLine($"{percentConverteP5:f2}%");
        }
    }
}
