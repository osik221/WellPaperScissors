using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rnd = new Random();
           bool playAgain = true;
           while (playAgain)
           {
                string[] choices = { "WELL", "PAPER", "SCISSORS" };
                string playerChoice = GetPlayerChoice(choices);
                string computerChoice = choices[rnd.Next(0, 3)];
                Console.WriteLine($"Player: {playerChoice}");
                Console.WriteLine($"Computer: {computerChoice}");

                DetermineTheWinner(playerChoice, computerChoice);

                playAgain = AskToContinue();
            }
        }
        static string GetPlayerChoice(string[] choices)
        {
            while (true)
            {
                Console.Write("Enter WELL, PAPER, or SCISSORS: ");
                string playerChoice = Console.ReadLine().ToUpper();
                if (choices.Contains(playerChoice))
                {
                    return playerChoice;
                }
                else
                {
                    Console.WriteLine("Pls try again:\\");
                }
            }
        }
        static void DetermineTheWinner(string playerchoice, string computerchoise)
        {
            if (playerchoice == computerchoise)
            {
                Console.WriteLine("It`s a draw");
            }
            else if ((playerchoice == "WELL" && computerchoise == "SCISSORS") ||
                    (playerchoice == "PAPER" && computerchoise == "WELL") ||
                    (playerchoice == "Scissors" && computerchoise == "PAPER"))
            {
                Console.WriteLine("You won");
            }else
            {
                Console.WriteLine("You lose(!");
            }
        }
        static bool AskToContinue()
        {
            while (true)
            {
                Console.WriteLine("Would you like to countinue? Yes/No");
                string aswer = Console.ReadLine().ToUpper();
                if ((aswer == "YES"))
                {
                    return true;
                }else if ((aswer == "NO"))
                {
                    Console.WriteLine("Goodbye!!!");
                    return false;
                }
            }
        }
    }
}
