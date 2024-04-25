namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetOfPeter = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int RAM = int.Parse(Console.ReadLine());

            double sumForVideocards = videocards * 250;

            double priceForProcessors = 0.35 * sumForVideocards;
            double sumForProcessors = processors * priceForProcessors;

            double priceForRAM = 0.1 * sumForVideocards;
            double sumForRAM = RAM * priceForRAM;

            double sumForALLStuff = sumForVideocards + sumForProcessors + sumForRAM;

            if (videocards > processors)
            {
                double discount = sumForALLStuff - (sumForALLStuff * 0.15);

                if (discount <= budgetOfPeter)
                {
                    double left = budgetOfPeter - discount;
                    Console.WriteLine("You have {0:F2} leva left!", left);
                }
                else
                {
                    double need = discount - budgetOfPeter;
                    Console.WriteLine("Not enough money! You need {0:F2} leva more!", need);
                }
            }
            else
            {
                double withoutDiscount = sumForALLStuff;

                if (withoutDiscount <= budgetOfPeter)
                {
                    double left = budgetOfPeter - withoutDiscount;
                    Console.WriteLine("You have {0:F2} leva left!", left);
                }
                else
                {
                    double need = withoutDiscount - budgetOfPeter;
                    Console.WriteLine("Not enough money! You need {0:F2} leva more!", need);
                }
            }
        }
    }
}
