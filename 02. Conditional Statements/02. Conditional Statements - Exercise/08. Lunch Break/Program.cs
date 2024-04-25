namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episodeCont = int.Parse(Console.ReadLine());
            int breakCont = int.Parse(Console.ReadLine());

            double timeForLunch = breakCont * 0.125;
            double timeForRelax = breakCont * 0.25;
            double leftTime = breakCont - timeForLunch - timeForRelax;

            if (leftTime >= episodeCont)
            {
                double watchTime = Math.Ceiling(leftTime - episodeCont);
                Console.WriteLine("You have enough time to watch {0} and left with {1} minutes free time.", name, watchTime);
            }
            else
            {
                double lateTime = Math.Ceiling(episodeCont - leftTime);
                Console.WriteLine("You don't have enough time to watch {0}, you need {1} more minutes.", name, lateTime);
            }
        }
    }
}
