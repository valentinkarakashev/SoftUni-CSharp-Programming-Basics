namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int pieces = length * width;

            while (true)
            {
                string piece = Console.ReadLine();
                if (piece == "STOP")
                {
                    Console.WriteLine($"{pieces} pieces are left.");
                    break;
                }
                else
                {
                    pieces -= int.Parse(piece);
                    if (pieces <= 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                        break;
                    }
                }
            }
        }
    }
}
