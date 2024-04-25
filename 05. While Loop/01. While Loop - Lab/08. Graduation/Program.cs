namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double sumOfGrades = 0;
            int exclidedCounter = 0;
            int grade = 1;


            while (grade <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade < 4)
                {
                    exclidedCounter++;
                }
                if (exclidedCounter == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade - 1} grade");
                    break;
                }
                sumOfGrades += currentGrade;
                grade++;
            }

            double avrg = sumOfGrades / 12;

            if (exclidedCounter < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avrg:F2}");
            }
        }
    }
}
