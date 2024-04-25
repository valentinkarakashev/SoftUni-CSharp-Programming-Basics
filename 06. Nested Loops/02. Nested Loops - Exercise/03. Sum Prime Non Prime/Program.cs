﻿namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeNumbersSum = 0, nonPrimeNumbersSum = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }

                int number = int.Parse(command);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                bool isPrime = true;
                double searchTo = Math.Sqrt(number);
                for (int i = 2; i <= searchTo; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeNumbersSum += number;
                }
                else
                {
                    nonPrimeNumbersSum += number;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbersSum}");
        }
    }
}
