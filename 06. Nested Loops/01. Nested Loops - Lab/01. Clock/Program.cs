namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int sec = 0; sec <= 59; sec++)
                {
                    Console.WriteLine($"{hour}:{sec}");
                }
            }
        }
    }
}
