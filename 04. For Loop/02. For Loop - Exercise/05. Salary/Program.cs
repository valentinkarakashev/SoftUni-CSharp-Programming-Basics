namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openBrowsers = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= openBrowsers; i++)
            {
                string browserName = Console.ReadLine();

                switch (browserName)
                {
                    case "Facebook": salary -= 150; break;
                    case "Instagram": salary -= 100; break;
                    case "Reddit": salary -= 50; break;
                    default:
                        break;
                }

                if (salary <= 0)
                {
                    break;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
