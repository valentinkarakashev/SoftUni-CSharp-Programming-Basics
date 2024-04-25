namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double yearPercent = double.Parse(Console.ReadLine());
            double dividend = depSum * (yearPercent / 100);
            double dividentForYear = dividend / 12;
            Console.WriteLine(depSum + months * dividentForYear);
        }
    }
}
