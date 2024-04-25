namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournirsPlayed = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            double allPoints = 0;
            double tournamentsWon = 0;

            for (int i = 1; i <= tournirsPlayed; i++)
            {
                string tournamentPart = Console.ReadLine();

                if (tournamentPart == "W")
                {
                    allPoints += 2000;
                    tournamentsWon += 1;
                }
                else if (tournamentPart == "F")
                {
                    allPoints += 1200;
                }
                else if (tournamentPart == "SF")
                {
                    allPoints += 720;
                }
            }

            double endPoints = allPoints + startingPoints;

            Console.WriteLine($"Final points: {endPoints}");
            Console.WriteLine($"Average points: {Math.Floor((endPoints - startingPoints) / tournirsPlayed)}");
            Console.WriteLine($"{tournamentsWon / tournirsPlayed * 100:F2}%");
        }
    }
}
