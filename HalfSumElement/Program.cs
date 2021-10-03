using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }                
            }
            int sumWithoutMaxNum = sum - maxNum;
            if (sumWithoutMaxNum == maxNum)
            {
                Console.WriteLine($"Yes\nSum = {maxNum}");
            }
            else
            {
                int difference = Math.Abs(sumWithoutMaxNum - maxNum);
                Console.WriteLine($"No\nDiff = {difference}");
            }
        }
    }
}
