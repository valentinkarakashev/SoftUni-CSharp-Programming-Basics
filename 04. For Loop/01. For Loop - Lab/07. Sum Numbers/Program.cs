namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
