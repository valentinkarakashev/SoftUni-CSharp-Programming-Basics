namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = 0;

            switch (town)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        commision = 0.05 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commision = 0.07 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commision = 0.08 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.12 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        commision = 0.045 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commision = 0.075 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commision = 0.1 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.13 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        commision = 0.055 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commision = 0.08 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commision = 0.12 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.145 * sales;
                        Console.WriteLine($"{commision:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
