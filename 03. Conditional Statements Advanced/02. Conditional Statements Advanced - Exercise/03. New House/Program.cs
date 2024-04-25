namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double SUM = 0;

            switch (flowers)
            {
                case "Roses": SUM = 5; break;
                case "Dahlias": SUM = 3.80; break;
                case "Tulips": SUM = 2.80; break;
                case "Narcissus": SUM = 3; break;
                case "Gladiolus": SUM = 2.50; break;
            }
            double totalPrice = SUM * countOfFlowers;

            if (flowers == "Roses" && countOfFlowers > 80)
            {
                totalPrice = totalPrice - (totalPrice * 0.1);
            }
            else if (flowers == "Dahlias" && countOfFlowers > 90)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            else if (flowers == "Tulips" && countOfFlowers > 80)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            else if (flowers == "Narcissus" && countOfFlowers < 120)
            {
                totalPrice = totalPrice + (totalPrice * 0.15);
            }
            else if (flowers == "Gladiolus" && countOfFlowers < 80)
            {
                totalPrice = totalPrice + (totalPrice * 0.2);
            }

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {flowers} and {budget - totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:F2} leva more.");
            }
        }
    }
}
