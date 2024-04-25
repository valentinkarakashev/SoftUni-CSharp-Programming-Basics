namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0,
                kidTickets = 0,
                standartTickets = 0,
                totalTickets = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Finish")
                {
                    break;
                }

                string movieName = command;
                int hallCapacity = int.Parse(Console.ReadLine());
                int soldTickets = 0;

                for (int i = 0; i < hallCapacity; i++)
                {
                    string ticketCommand = Console.ReadLine();
                    if (ticketCommand == "End")
                    {
                        break;
                    }

                    switch (ticketCommand)
                    {
                        case "standard": standartTickets++; break;
                        case "student": studentTickets++; break;
                        case "kid": kidTickets++; break;
                    }

                    totalTickets++;
                    soldTickets++;
                }

                Console.WriteLine($"{movieName} - {(soldTickets * 1.0 / hallCapacity) * 100:F2}% full.");
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTickets * 1.0 / totalTickets) * 100:F2}% student tickets.");
            Console.WriteLine($"{(standartTickets * 1.0 / totalTickets) * 100:F2}% standard tickets.");
            Console.WriteLine($"{(kidTickets * 1.0 / totalTickets) * 100:F2}% kids tickets.");
        }
    }
}
