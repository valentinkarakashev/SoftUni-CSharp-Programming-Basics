namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int countOfStatists = int.Parse(Console.ReadLine());
            double priceOfStatistssWear = double.Parse(Console.ReadLine());

            double sumForDecor = 0.1 * filmBudget;
            double sumForWear = countOfStatists * priceOfStatistssWear;
            if (countOfStatists > 150)
            {
                double discount = 0.1 * sumForWear;
                double sumForWearr = sumForWear - discount;
                double sumForTheFilm = sumForDecor + sumForWearr;
                double leftMoney = filmBudget - sumForTheFilm;
                if (leftMoney >= 0)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine("Wingard starts filming with {0:F2} leva left.", leftMoney);
                }
                else
                {
                    double leftMoney1 = leftMoney * -1;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine("Wingard needs {0:F2} leva more.", leftMoney1);
                }
            }
            else
            {
                double sumForTheFilm = sumForDecor + sumForWear;
                double leftMoney = filmBudget - sumForTheFilm;
                if (leftMoney >= 0)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine("Wingard starts filming with {0:F2} leva left.", leftMoney);
                }
                else
                {
                    double leftMoney1 = leftMoney * -1;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine("Wingard needs {0:F2} leva more.", leftMoney1);
                }
            }
        }
    }
}
