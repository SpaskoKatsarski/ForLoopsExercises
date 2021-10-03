using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            //⦁	W - ако е победител получава 2000 точки
            //⦁	F - ако е финалист получава 1200 точки
            //⦁	SF - ако е полуфиналист получава 720 точки
            const double WINNER_POINTS = 2000;
            const double FINALIST_POINTS = 1200;
            const double SEMI_FINALIST_POINTS = 720;

            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            double totalPoints = startingPoints;
            int tournamentsWon = 0;
            double averagePoints = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    totalPoints += WINNER_POINTS;
                    tournamentsWon++;
                }
                else if (stage == "F")
                {
                    totalPoints += FINALIST_POINTS;
                }
                else
                {
                    totalPoints += SEMI_FINALIST_POINTS;
                }
            }
            averagePoints += (double) (totalPoints - startingPoints) / tournaments;

            double percentTournamentsWon =(double) tournamentsWon / tournaments * 100;

            Console.WriteLine($"Final points: {totalPoints}\nAverage points: {Math.Floor(averagePoints)}\n{percentTournamentsWon:f2}%");
        }
    }
}
