namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = width * height * length;

            while (true)
            {
                string spaceToGet = Console.ReadLine();
                if (spaceToGet == "Done")
                {
                    Console.WriteLine($"{freeSpace} Cubic meters left.");
                    break;
                }
                else
                {
                    freeSpace -= int.Parse(spaceToGet);
                    if (freeSpace <= 0)
                    {
                        Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                        break;
                    }
                }
            }
        }
    }
}
