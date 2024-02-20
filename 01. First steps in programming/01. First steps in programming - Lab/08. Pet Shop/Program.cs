namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double sumDog = dogFood * 2.5;
            double sumCat = catFood * 4;
            double sumAll = sumDog + sumCat;
            Console.WriteLine($"{sumAll} lv.");
        }
    }
}
