namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pricePerYear = int.Parse(Console.ReadLine());

            double priceBasketballSneakers = pricePerYear - (pricePerYear * 0.4);
            double priceBasketballOutfit = priceBasketballSneakers - (priceBasketballSneakers * 0.2);
            double priceBasketballBall = priceBasketballOutfit / 4;
            double priceBasketballAccessories = priceBasketballBall / 5;
            double priceAll = pricePerYear + priceBasketballSneakers + priceBasketballOutfit + priceBasketballBall + priceBasketballAccessories;

            Console.WriteLine($"{priceAll}");
        }
    }
}
