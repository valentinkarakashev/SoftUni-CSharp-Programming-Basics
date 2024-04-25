namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judgesCount = int.Parse(Console.ReadLine());
            double presentationsAverageGradesSum = 0;
            int presentationsCount = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Finish")
                {
                    break;
                }

                presentationsCount++;
                double gradesSum = 0;
                for (int i = 0; i < judgesCount; i++)
                {
                    gradesSum += double.Parse(Console.ReadLine());
                }

                presentationsAverageGradesSum += gradesSum / judgesCount;
                Console.WriteLine($"{command} - {gradesSum / judgesCount:F2}.");
            }

            Console.WriteLine($"Student's final assessment is {presentationsAverageGradesSum / presentationsCount:F2}.");
        }
    }
}
