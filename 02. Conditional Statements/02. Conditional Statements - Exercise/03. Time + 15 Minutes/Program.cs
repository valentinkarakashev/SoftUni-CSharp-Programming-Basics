namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursInMinutes = hour * 60;

            int fullTime = hoursInMinutes + minutes + 15;

            int hours = fullTime / 60;
            int minute = fullTime % 60;

            if (hours > 23)
            {
                hours -= 24;
            }

            if (minute > 59)
            {
                minute -= 60;
            }

            if (minute < 10)
            {
                Console.WriteLine($"{hours}:0{minute}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minute}");
            }
        }
    }
}
