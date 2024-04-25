namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plastic = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumPlastic = (plastic + 2) * 1.50;
            double sumPaint = (paint + paint * 0.1) * 14.50;
            double sumThinner = thinner * 5;

            double sumAll = sumPlastic + sumPaint + sumThinner + 0.4;
            double sumWorkMan = (sumAll * 0.3) * hours;
            double endSum = sumAll + sumWorkMan;
            Console.WriteLine($"{endSum}");
        }
    }
}
