﻿namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < pairsCount; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());

                leftSum += firstNumber;
            }

            for (int i = 0; i < pairsCount; i++)
            {
                int secondNumber = int.Parse(Console.ReadLine());

                rightSum += secondNumber;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);

                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
