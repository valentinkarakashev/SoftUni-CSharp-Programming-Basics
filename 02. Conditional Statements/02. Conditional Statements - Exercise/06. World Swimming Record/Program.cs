namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

            double haveToSwim = distanceInMeters * timeInSecondsForOneMeter;
            double with15SecondsLate = Math.Floor(distanceInMeters / 15) * 12.5;
            double fullTime = haveToSwim + with15SecondsLate;
            if (fullTime >= recordInSeconds)
            {
                double lose = fullTime - recordInSeconds;
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", lose);
            }
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", fullTime);
            }
        }
    }
}
