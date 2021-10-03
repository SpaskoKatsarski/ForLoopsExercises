using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            const double NEEDED_POINTS_FOR_OSCAR = 1250.5;

            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int countExamers = int.Parse(Console.ReadLine());

            double sumPoints = academyPoints;

            for (int i = 0; i < countExamers; i++)
            {
                string examerName = Console.ReadLine();
                double pointsFromExamer = double.Parse(Console.ReadLine());
    
                sumPoints += (examerName.Length * pointsFromExamer) / 2;

                if (sumPoints > NEEDED_POINTS_FOR_OSCAR)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {sumPoints:f1}!");
                    break;
                }
            }

            if (sumPoints <= NEEDED_POINTS_FOR_OSCAR)
            {
                double difference = Math.Abs(NEEDED_POINTS_FOR_OSCAR - sumPoints);
                Console.WriteLine($"Sorry, {actorName} you need {difference:f1} more!");
            }
        }
    }
}
