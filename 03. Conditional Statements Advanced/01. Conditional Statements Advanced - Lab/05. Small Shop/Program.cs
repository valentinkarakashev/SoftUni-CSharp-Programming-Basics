﻿namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double SUM = 0;

            if (town == "Sofia")
            {
                switch (productName)
                {
                    case "coffee": SUM = quantity * 0.50; break;
                    case "water": SUM = quantity * 0.80; break;
                    case "beer": SUM = quantity * 1.20; break;
                    case "sweets": SUM = quantity * 1.45; break;
                    case "peanuts": SUM = quantity * 1.60; break;
                }
            }
            else if (town == "Plovdiv")
            {
                switch (productName)
                {
                    case "coffee": SUM = quantity * 0.40; break;
                    case "water": SUM = quantity * 0.70; break;
                    case "beer": SUM = quantity * 1.15; break;
                    case "sweets": SUM = quantity * 1.30; break;
                    case "peanuts": SUM = quantity * 1.50; break;
                }
            }
            else if (town == "Varna")
            {
                switch (productName)
                {
                    case "coffee": SUM = quantity * 0.45; break;
                    case "water": SUM = quantity * 0.70; break;
                    case "beer": SUM = quantity * 1.10; break;
                    case "sweets": SUM = quantity * 1.35; break;
                    case "peanuts": SUM = quantity * 1.55; break;
                }
            }
            Console.WriteLine(SUM);
        }
    }
}
