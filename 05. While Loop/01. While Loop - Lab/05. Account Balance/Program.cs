namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numInStr = Console.ReadLine();
            double money = 0;

            while (numInStr != "NoMoreMoney")
            {
                double num = double.Parse(numInStr);
                if (num < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {num:F2}");
                money += num;

                numInStr = Console.ReadLine();
            }

            Console.WriteLine($"Total: {money:F2}");
        }
    }
}
