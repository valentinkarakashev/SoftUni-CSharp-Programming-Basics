namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int assessorsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= assessorsCount; i++)
            {
                string assessorName = Console.ReadLine();
                double assessorPoints = double.Parse(Console.ReadLine());

                double points = assessorName.Length * assessorPoints / 2;
                startingPoints += points;

                if (startingPoints > 1250.5)
                {
                    break;
                }
            }

            if (startingPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {startingPoints:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - startingPoints:F1} more!");
            }
        }
    }
}
