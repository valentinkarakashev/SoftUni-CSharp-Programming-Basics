namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int MaxNumber = int.MinValue;
            int MinNumber = int.MaxValue;

            for (int i = 1; i <= numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < MinNumber)
                {
                    MinNumber = number;
                }
                if (number > MaxNumber)
                {
                    MaxNumber = number;
                }
            }
            Console.WriteLine($"Max number: {MaxNumber}");
            Console.WriteLine($"Min number: {MinNumber}");
        }
    }
}
