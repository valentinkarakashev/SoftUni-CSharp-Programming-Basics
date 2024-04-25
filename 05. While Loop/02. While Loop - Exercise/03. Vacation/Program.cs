namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int spend = 0;
            int daysGone = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double spendSave = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    money -= spendSave;
                    spend++;
                    if (money < 0)
                    {
                        money = 0;
                    }

                }
                else
                {
                    spend = 0;
                    money += spendSave;
                }

                if (spend == 5)
                {
                    daysGone++;
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(daysGone);
                    break;
                }

                if (money >= neededMoney)
                {
                    daysGone++;
                    Console.WriteLine($"You saved the money for {daysGone} days.");
                    break;
                }

                daysGone++;
            }
        }
    }
}
