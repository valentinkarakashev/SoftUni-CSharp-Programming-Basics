﻿namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysToReadTheBook = int.Parse(Console.ReadLine());
            Console.WriteLine((pages / pagesPerHour) / daysToReadTheBook);
        }
    }
}
