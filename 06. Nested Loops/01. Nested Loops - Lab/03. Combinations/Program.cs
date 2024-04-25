namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int x = 0; x <= number; x++)
            {
                for (int y = 0; y <= number; y++)
                {
                    for (int z = 0; z <= number; z++)
                    {
                        if (x + y + z == number)
                        {
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
