namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "";
            double spendMoney = 0;
            string place1 = "";

            if (budget <= 100)
            {
                place = "Bulgaria";
                if (season == "summer")
                {
                    place1 = "Camp";
                    spendMoney = budget * 0.3;
                }
                else if (season == "winter")
                {
                    place1 = "Hotel";
                    spendMoney = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                place = "Balkans";
                if (season == "summer")
                {
                    place1 = "Camp";
                    spendMoney = budget * 0.4;
                }
                else if (season == "winter")
                {
                    place1 = "Hotel";
                    spendMoney = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                place = "Europe";
                place1 = "Hotel";
                spendMoney = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{place1} - {spendMoney:F2}");
        }
    }
}
