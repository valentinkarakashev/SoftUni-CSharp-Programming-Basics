namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int maxNum = int.MinValue;

            while (num != "Stop")
            {
                int num1 = int.Parse(num);
                if (num1 > maxNum)
                {
                    maxNum = num1;
                }

                num = Console.ReadLine();
            }

            Console.WriteLine(maxNum);
        }
    }
}
