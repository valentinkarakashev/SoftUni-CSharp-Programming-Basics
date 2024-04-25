namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            int ExMinutes = hourExam * 60 + minuteExam;
            int ArrMinutes = hourArrive * 60 + minuteArrive;

            if (ExMinutes < ArrMinutes)
            {
                Console.WriteLine("Late");
                int minutesDifference = ArrMinutes - ExMinutes;
                if (minutesDifference < 60)
                {
                    Console.WriteLine($"{minutesDifference} minutes after the start");
                }
                else
                {
                    int hours = minutesDifference / 60;
                    int minutes = minutesDifference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }

            }
            else if (ArrMinutes < ExMinutes - 30)
            {
                Console.WriteLine("Early");
                int minutesDifference = ExMinutes - ArrMinutes;
                if (minutesDifference < 60)
                {
                    Console.WriteLine($"{minutesDifference} minutes before the start");
                }
                else
                {
                    int hours = minutesDifference / 60;
                    int minutes = minutesDifference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                double minutesDifference = ExMinutes - ArrMinutes;
                Console.WriteLine($"{minutesDifference} minutes before the start");
            }
        }
    }
}
