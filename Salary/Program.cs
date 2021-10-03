using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FACEBOOK = 150;
            const int INSTAGRAM = 100;
            const int REDDIT = 50;

            int openedTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i <= openedTabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }

                string website = Console.ReadLine();
                if (website == "Facebook")
                {
                    salary -= FACEBOOK;
                }
                else if (website == "Instagram")
                {
                    salary -= INSTAGRAM;
                }
                else if (website == "Reddit")
                {
                    salary -= REDDIT;
                }
                
            }
            Console.WriteLine($"{salary}");
        }
    }
}
