namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int minNum = int.MaxValue;

            while (num != "Stop")
            {
                int num1 = int.Parse(num);
                if (num1 < minNum)
                {
                    minNum = num1;
                }

                num = Console.ReadLine();
            }

            Console.WriteLine(minNum);
        }
    }
}
