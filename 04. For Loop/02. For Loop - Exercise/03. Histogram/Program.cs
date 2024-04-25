namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

            for (int i = 1; i <= number; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1 += 1;
                }
                else if (200 <= num && num <= 399)
                {
                    p2 += 1;
                }
                else if (400 <= num && num <= 599)
                {
                    p3 += 1;
                }
                else if (600 <= num && num <= 799)
                {
                    p4 += 1;
                }
                else if (num >= 800)
                {
                    p5 += 1;
                }
            }

            Console.WriteLine($"{p1 * 1.0 / number * 100:F2}%");
            Console.WriteLine($"{p2 * 1.0 / number * 100:F2}%");
            Console.WriteLine($"{p3 * 1.0 / number * 100:F2}%");
            Console.WriteLine($"{p4 * 1.0 / number * 100:F2}%");
            Console.WriteLine($"{p5 * 1.0 / number * 100:F2}%");
        }
    }
}
