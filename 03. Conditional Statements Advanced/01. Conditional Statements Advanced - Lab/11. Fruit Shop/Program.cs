namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double result = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana": result = 2.50 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "apple": result = 1.20 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "orange": result = 0.85 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "grapefruit": result = 1.45 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "kiwi": result = 2.70 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "pineapple": result = 5.50 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "grapes": result = 3.85 * quantity; Console.WriteLine("{0:F2}", result); break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": result = 2.70 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "apple": result = 1.25 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "orange": result = 0.90 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "grapefruit": result = 1.60 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "kiwi": result = 3.00 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "pineapple": result = 5.60 * quantity; Console.WriteLine("{0:F2}", result); break;
                    case "grapes": result = 4.20 * quantity; Console.WriteLine("{0:F2}", result); break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
