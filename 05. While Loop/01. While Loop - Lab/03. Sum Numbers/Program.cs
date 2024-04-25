namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double sumOfNums = 0;

            while (sumOfNums < number)
            {
                int num1 = int.Parse(Console.ReadLine());
                sumOfNums += num1;
            }

            Console.WriteLine(sumOfNums);
        }
    }
}
