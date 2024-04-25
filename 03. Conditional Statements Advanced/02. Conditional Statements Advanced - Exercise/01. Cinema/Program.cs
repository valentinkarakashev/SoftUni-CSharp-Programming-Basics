namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double allSeats = rows * columns;
            double fullPrice = 0;

            switch (projection)
            {
                case "Premiere": fullPrice = allSeats * 12.00; break;
                case "Normal": fullPrice = allSeats * 7.50; break;
                case "Discount": fullPrice = allSeats * 5.00; break;
                default:
                    break;
            }
            Console.WriteLine($"{fullPrice:F2} leva");
        }
    }
}
