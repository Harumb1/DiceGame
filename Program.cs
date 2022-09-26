using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int userPoints = 0;
            int computerPoints = 0;

            Random random = new Random();


            Console.WriteLine("Dice game!");
            Console.ReadKey(true);

            for (int i = 0; i < 10; i++)
            {
                int cpuRoll = random.Next(1, 7);
                Console.WriteLine($"Round {i + 1}");
                Console.WriteLine("Your rival rolled " + cpuRoll);
                Console.WriteLine("Press enter to continue... ");
                Console.ReadKey(true);
                int userRoll = random.Next(1, 7);
                Console.WriteLine("You rolled " + userRoll);

                if (cpuRoll > userRoll)
                {
                    Console.WriteLine("You lost this round!");
                    computerPoints++;
                    Console.WriteLine($"The score is now {computerPoints}:{userPoints}");
                }
                else if (cpuRoll < userRoll)
                {
                    Console.WriteLine("You won this round!");
                    userPoints++;
                    Console.WriteLine($"The score is now {computerPoints}:{userPoints}");
                }
                else if (cpuRoll == userRoll)
                {
                    Console.WriteLine("This round is a draw!");
                    Console.WriteLine($"The score is now {computerPoints}:{userPoints}");
                }
                Console.ReadLine();
               
            }

            Console.WriteLine($"The result is {computerPoints}:{userPoints}");
            
            if (computerPoints > userPoints)
            {
                Console.WriteLine("You lost!");
            }
            else if (computerPoints < userPoints)
            {
                Console.WriteLine("You won!");
            }
            else if (computerPoints == userPoints)
            {
                Console.WriteLine("This game is a draw!");
            }
        }

    }


}
    


