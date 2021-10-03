using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;

            for (int i = 0; i < groups; i++)
            {
                int climbers = int.Parse(Console.ReadLine());

                if (climbers < 6)
                {
                    group1 += climbers;
                }
                else if (climbers < 13)
                {
                    group2 += climbers;
                }
                else if (climbers < 26)
                {
                    group3 += climbers;
                }
                else if (climbers < 41)
                {
                    group4 += climbers;
                }
                else
                {
                    group5 += climbers;
                }
            }

            int totalClimbers = group1 + group2 + group3 + group4 + group5;
            double convertPercentGroup1 = (double) group1 / totalClimbers * 100;
            double convertPercentGroup2 = (double) group2 / totalClimbers * 100;
            double convertPercentGroup3 = (double) group3 / totalClimbers * 100;
            double convertPercentGroup4 = (double) group4 / totalClimbers * 100;
            double convertPercentGroup5 = (double) group5 / totalClimbers * 100;

            Console.WriteLine($"{convertPercentGroup1:f2}%\n{convertPercentGroup2:f2}%\n{convertPercentGroup3:f2}%\n{convertPercentGroup4:f2}%\n{convertPercentGroup5:f2}%");
        }
    }
}
