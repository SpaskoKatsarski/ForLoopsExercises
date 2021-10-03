using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLilly = int.Parse(Console.ReadLine());
            double priceLoundryMachine = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int totalMoney = 0;

            for (int i = 1; i <= ageLilly; i++)
            {
                money += 5;

                if (i % 2 == 0)
                {
                    totalMoney += money - 1;
                }
                else
                {
                    toys++;
                }
            }

            int priceToys = pricePerToy * toys;
            int allMoney = priceToys + totalMoney;
            double difference = Math.Abs(allMoney - priceLoundryMachine);

            if (allMoney >= priceLoundryMachine)
            {
                Console.WriteLine($"Yes! {difference:f2}");
            }
            else
            {
                Console.WriteLine($"No! {difference:f2}");
            }
        }
    }
}
