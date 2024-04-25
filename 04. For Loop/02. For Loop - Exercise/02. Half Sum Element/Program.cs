namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;


            for (int i = 1; i <= numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            int result = sum - maxNumber;

            if (result == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                int diff = Math.Abs(result - maxNumber);
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
