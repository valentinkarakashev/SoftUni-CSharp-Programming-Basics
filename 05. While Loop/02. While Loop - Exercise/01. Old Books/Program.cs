namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string name1 = Console.ReadLine();
            int countOfBooks = 0;

            while (name1 != name)
            {
                if (name1 == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {countOfBooks} books.");
                    break;
                }
                countOfBooks++;
                name1 = Console.ReadLine();
            }

            if (name1 == name && name != "No More Books")
            {
                Console.WriteLine($"You checked {countOfBooks} books and found it.");
            }
        }
    }
}
