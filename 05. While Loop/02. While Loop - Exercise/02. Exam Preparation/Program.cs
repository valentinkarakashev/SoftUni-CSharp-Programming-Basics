namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int badGradesCount = 0;
            double allGrades = 0;
            int taskCount = 0;
            string lastProblem = "";
            int gradeCount = 0;

            while (true)
            {
                string taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    Console.WriteLine($"Average score: {allGrades / gradeCount:F2}");
                    Console.WriteLine($"Number of problems: {taskCount}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;

                }
                lastProblem = taskName;
                int grade = int.Parse(Console.ReadLine());

                allGrades += grade;
                taskCount++;
                gradeCount++;

                if (grade <= 4)
                {
                    badGradesCount++;
                    if (badGradesCount == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
                        break;
                    }
                }
            }
        }
    }
}
