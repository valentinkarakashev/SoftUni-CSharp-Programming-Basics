namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double k = 1;

            while (k <= num)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
