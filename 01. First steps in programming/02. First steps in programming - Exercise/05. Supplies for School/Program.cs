namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packagesOfPens = int.Parse(Console.ReadLine());
            int packagesOfMarkers = int.Parse(Console.ReadLine());
            int litersOfPreparate = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double priceOfAll = packagesOfPens * 5.80 + packagesOfMarkers * 7.20 + litersOfPreparate * 1.20;
            double result = priceOfAll - (priceOfAll * discount / 100);
            Console.WriteLine(result);
        }
    }
}
