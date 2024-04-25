namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int sum = 0;
            int moneyReceived = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum += moneyReceived;
                    moneyReceived += 10;
                    sum--;
                }
                else
                {
                    sum += toyPrice;
                }
            }

            if (washingMashinePrice > sum)
            {
                double leave = washingMashinePrice - sum;
                Console.WriteLine($"No! {leave:F2}");
            }
            else if (washingMashinePrice <= sum)
            {
                double leave = sum - washingMashinePrice;
                Console.WriteLine($"Yes! {leave:F2}");
            }
        }
    }
}
