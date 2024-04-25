namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int overnightStayCount = int.Parse(Console.ReadLine());

            if (mounth == "May" || mounth == "October")
            {
                double studio = 50;
                double apartment = 65;
                double priceStudio;
                double priceApartment;
                if (overnightStayCount > 7 && overnightStayCount <= 14)
                {
                    double discount = studio - (studio * 0.05);
                    priceStudio = discount * overnightStayCount;
                    priceApartment = apartment * overnightStayCount;
                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
                else if (overnightStayCount > 14)
                {
                    double discount = studio - (studio * 0.3);
                    double discount1 = apartment - (apartment * 0.1);
                    priceStudio = discount * overnightStayCount;
                    priceApartment = discount1 * overnightStayCount;
                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
                else
                {
                    priceApartment = apartment * overnightStayCount;
                    priceStudio = studio * overnightStayCount;
                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                double studio = 75.20;
                double apartment = 68.70;
                double priceStudio;
                double priceApartment;
                if (overnightStayCount > 14)
                {
                    double discount = studio - (studio * 0.2);
                    double discount1 = apartment - (apartment * 0.1);
                    priceStudio = discount * overnightStayCount;
                    priceApartment = discount1 * overnightStayCount;
                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
                else
                {
                    priceApartment = apartment * overnightStayCount;
                    priceStudio = studio * overnightStayCount;
                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
            }
            else if (mounth == "July" || mounth == "August")
            {
                double studio = 76;
                double apartment = 77;
                double priceStudio;
                double priceApartment;
                if (overnightStayCount > 14)
                {
                    double discount1 = apartment - (apartment * 0.1);
                    priceApartment = discount1 * overnightStayCount;
                    priceStudio = studio * overnightStayCount;
                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
                else
                {
                    priceApartment = apartment * overnightStayCount;
                    priceStudio = studio * overnightStayCount;
                    Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
                    Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                }
            }
        }
    }
}
