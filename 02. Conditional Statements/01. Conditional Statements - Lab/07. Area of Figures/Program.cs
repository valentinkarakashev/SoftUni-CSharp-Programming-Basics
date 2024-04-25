namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double side1 = double.Parse(Console.ReadLine());
                double area1 = side1 * side1;
                Console.WriteLine("{0:F3}", area1);
            }
            else if (figure == "rectangle")
            {
                double side11 = double.Parse(Console.ReadLine());
                double side12 = double.Parse(Console.ReadLine());
                double area11 = side11 * side12;
                Console.WriteLine("{0:F3}", area11);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area111 = (radius * radius) * Math.PI;
                Console.WriteLine("{0:F3}", area111);
            }
            else if (figure == "triangle")
            {
                double side111 = double.Parse(Console.ReadLine());
                double side112 = double.Parse(Console.ReadLine());
                double area1111 = (side111 * side112) / 2;
                Console.WriteLine("{0:F3}", area1111);
            }
        }
    }
}
