namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double size = length * width * height;
            double sizeIntoLiters = size / 1000;
            double emptyPlace = percent / 100;
            double litersNeed = sizeIntoLiters * (1 - emptyPlace);

            Console.WriteLine(litersNeed);
        }
    }
}
