namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numOfprojects = int.Parse(Console.ReadLine());
            int timeTocreate = numOfprojects * 3;
            Console.WriteLine($"The architect {name} will need {timeTocreate} hours to complete {numOfprojects} project/s.");
        }
    }
}
