namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            double price;
            double discount;

            switch (roomType)
            {
                case "room for one person":
                    price = 18 * days;
                    if (rating == "positive")
                    {
                        price = price + (price * 0.25);
                        Console.WriteLine($"{price:F2}");
                    }
                    else if (rating == "negative")
                    {
                        price = price - (price * 0.1);
                        Console.WriteLine($"{price:F2}");
                    }
                    break;
                case "apartment":
                    if (days < 10)
                    {
                        price = 25 * days;
                        discount = price - (price * 0.3);
                        if (rating == "positive")
                        {
                            price = discount + (discount * 0.25);
                            Console.WriteLine($"{price:F2}");
                        }
                        else if (rating == "negative")
                        {
                            price = discount - (discount * 0.1);
                            Console.WriteLine($"{price:F2}");
                        }
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = 25 * days;
                        discount = price - (price * 0.35);
                        if (rating == "positive")
                        {
                            price = discount + (discount * 0.25);
                            Console.WriteLine($"{price:F2}");
                        }
                        else if (rating == "negative")
                        {
                            price = discount - (discount * 0.1);
                            Console.WriteLine($"{price:F2}");
                        }
                    }
                    else if (days >= 15)
                    {
                        price = 25 * days;
                        discount = price - (price * 0.5);
                        if (rating == "positive")
                        {
                            price = discount + (discount * 0.25);
                            Console.WriteLine($"{price:F2}");
                        }
                        else if (rating == "negative")
                        {
                            price = discount - (discount * 0.1);
                            Console.WriteLine($"{price:F2}");
                        }
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        price = 35 * days;
                        discount = price - (price * 0.1);
                        if (rating == "positive")
                        {
                            price = discount + (discount * 0.25);
                            Console.WriteLine($"{price:F2}");
                        }
                        else if (rating == "negative")
                        {
                            price = discount - (discount * 0.1);
                            Console.WriteLine($"{price:F2}");
                        }
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = 35 * days;
                        discount = price - (price * 0.15);
                        if (rating == "positive")
                        {
                            price = discount + (discount * 0.25);
                            Console.WriteLine($"{price:F2}");
                        }
                        else if (rating == "negative")
                        {
                            price = discount - (discount * 0.1);
                            Console.WriteLine($"{price:F2}");
                        }
                    }
                    else if (days >= 15)
                    {
                        price = 35 * days;
                        discount = price - (price * 0.2);
                        if (rating == "positive")
                        {
                            price = discount + (discount * 0.25);
                            Console.WriteLine($"{price:F2}");
                        }
                        else if (rating == "negative")
                        {
                            price = discount - (discount * 0.1);
                            Console.WriteLine($"{price:F2}");
                        }
                    }
                    break;
            }
        }
    }
}
