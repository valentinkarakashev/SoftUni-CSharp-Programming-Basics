namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double priceChickenMenu = chickenMenu * 10.35;
            double priceFishMenu = fishMenu * 12.40;
            double priceVegetarianMenu = vegetarianMenu * 8.15;

            double allMenuPrice = priceChickenMenu + priceFishMenu + priceVegetarianMenu;

            double priceDessert = 0.2 * allMenuPrice;

            double priceDeliver = 2.50;

            double allPrice = allMenuPrice + priceDessert + priceDeliver;

            Console.WriteLine($"{allPrice}");
        }
    }
}
