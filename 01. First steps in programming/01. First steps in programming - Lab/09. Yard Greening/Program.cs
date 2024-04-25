namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double price = 7.61 * area;
            double discount = 0.18 * price;
            double priceDiscount = price - discount;
            Console.WriteLine($"The final price is: {priceDiscount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
