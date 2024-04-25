namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double resultt;

            switch (operation)
            {
                case "+":
                    resultt = number1 + number2;
                    if (resultt % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {resultt} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {resultt} - odd");
                    }
                    break;
                case "-":
                    resultt = number1 - number2;
                    if (resultt % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {resultt} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {resultt} - odd");
                    }
                    break;
                case "*":
                    resultt = number1 * number2;
                    if (resultt % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {resultt} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {resultt} - odd");
                    }
                    break;
            }
            switch (operation)
            {
                case "/":
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        resultt = number1 / (number2 * 1.0);
                        Console.WriteLine($"{number1} {operation} {number2} = {resultt:F2}");
                    }
                    break;
                case "%":
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        resultt = number1 % number2;
                        Console.WriteLine($"{number1} {operation} {number2} = {resultt}");
                    }
                    break;
            }
        }
    }
}
