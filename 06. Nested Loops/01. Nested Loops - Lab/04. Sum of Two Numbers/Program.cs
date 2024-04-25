namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int numberOf = 0;
            int counter = 0;

            for (int x = firstNum; x <= secondNum; x++)
            {
                for (int y = firstNum; y <= secondNum; y++)
                {
                    if (x + y == magicNum)
                    {
                        numberOf++;
                        counter++;
                        if (counter == 1)
                        {
                            Console.WriteLine($"Combination N:{numberOf} ({x} + {y} = {magicNum})");
                            break;
                        }
                    }
                    else
                    {
                        numberOf++;
                    }
                }
                if (counter == 1)
                {
                    break;
                }
            }

            if (counter != 1)
            {
                Console.WriteLine($"{numberOf} combinations - neither equals {magicNum}");
            }
        }
    }
}
