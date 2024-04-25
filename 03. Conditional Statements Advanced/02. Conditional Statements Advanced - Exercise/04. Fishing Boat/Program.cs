namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishersCount = int.Parse(Console.ReadLine());
            double rent = 0;

            switch (season)
            {
                case "Spring": rent = 3000; break;
                case "Summer":
                case "Autumn": rent = 4200; break;
                case "Winter": rent = 2600; break;
            }

            if (fishersCount <= 6)
            {
                rent = rent - (rent * 0.1);
            }
            else if (fishersCount >= 7 && fishersCount <= 11)
            {
                rent = rent - (rent * 0.15);
            }
            else if (fishersCount >= 12)
            {
                rent = rent - (rent * 0.25);
            }

            if (fishersCount % 2 == 0 && season != "Autumn")
            {
                rent = rent - (rent * 0.05);
            }

            if (budget >= rent)
            {
                Console.WriteLine($"Yes! You have {budget - rent:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rent - budget:F2} leva.");
            }
        }
    }
}
