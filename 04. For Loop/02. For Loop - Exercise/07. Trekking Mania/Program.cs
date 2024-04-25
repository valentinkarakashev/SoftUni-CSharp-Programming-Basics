namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());

            int Musala = 0, Monblan = 0, Kilimandzharo = 0, K2 = 0, Everest = 0;

            for (int i = 1; i <= groupsCount; i++)
            {
                int membersCount = int.Parse(Console.ReadLine());

                if (membersCount <= 5)
                {
                    Musala += membersCount;
                }
                else if (membersCount >= 6 && membersCount <= 12)
                {
                    Monblan += membersCount;
                }
                else if (membersCount >= 13 && membersCount <= 25)
                {
                    Kilimandzharo += membersCount;
                }
                else if (membersCount >= 26 && membersCount <= 40)
                {
                    K2 += membersCount;
                }
                else if (membersCount >= 41)
                {
                    Everest += membersCount;
                }
            }

            double allMembers = Musala + Monblan + Kilimandzharo + K2 + Everest;

            Console.WriteLine($"{Musala / allMembers * 100:F2}%");
            Console.WriteLine($"{Monblan / allMembers * 100:F2}%");
            Console.WriteLine($"{Kilimandzharo / allMembers * 100:F2}%");
            Console.WriteLine($"{K2 / allMembers * 100:F2}%");
            Console.WriteLine($"{Everest / allMembers * 100:F2}%");
        }
    }
}
