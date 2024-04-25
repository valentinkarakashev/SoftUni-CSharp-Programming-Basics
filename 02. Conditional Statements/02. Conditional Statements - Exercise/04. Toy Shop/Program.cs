namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int teddyBear = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int truckToy = int.Parse(Console.ReadLine());

            double sumOfAllToys = puzzles * 2.60 + doll * 3 + teddyBear * 4.10 + minions * 8.20 + truckToy * 2;
            double countOfToys = puzzles + doll + teddyBear + minions + truckToy;

            if (countOfToys >= 50)
            {
                double discount = sumOfAllToys * 0.25;
                double endPrice = sumOfAllToys - discount;
                double rent = endPrice * 0.1;
                double win = endPrice - rent;

                if (win >= tripPrice)
                {
                    double rest = win - tripPrice;
                    Console.WriteLine("Yes! {0:F2} lv left.", rest);
                }
                else
                {
                    double lose = tripPrice - win;
                    Console.WriteLine("Not enough money! {0:F2} lv needed.", lose);
                }
            }
            else
            {
                double rent = sumOfAllToys * 0.1;
                double win = sumOfAllToys - rent;

                if (win >= tripPrice)
                {
                    double rest = win - tripPrice;
                    Console.WriteLine("Yes! {0:F2} lv left.", rest);
                }
                else
                {
                    double lose = tripPrice - win;
                    Console.WriteLine("Not enough money! {0:F2} lv needed.", lose);
                }
            }
        }
    }
}
