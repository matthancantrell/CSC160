using System;
using System.Collections.Generic;
using MasterMindLibrary;


namespace MasterMind
{
    class Program
    {
        // List of Pegs & Colors
        static List<Peg> pegList = new List<Peg>()
        {
            new Peg(ConsoleColor.White, ConsoleColor.Red),
            new Peg(ConsoleColor.White, ConsoleColor.Blue),
            new Peg(ConsoleColor.Black, ConsoleColor.Green),
            new Peg(ConsoleColor.Black, ConsoleColor.Yellow),
            new Peg(ConsoleColor.Black, ConsoleColor.Cyan),
            new Peg(ConsoleColor.White, ConsoleColor.Magenta),
            new Peg(ConsoleColor.White, ConsoleColor.DarkGray),
            new Peg(ConsoleColor.White, ConsoleColor.DarkRed)
        };

        // Game Code
        static void Main(string[] args)
        {
            List<Attempt> allAttempts = new List<Attempt>();

            // Startup & Welcome Screen
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Mastermind!");
            Console.ResetColor();

            // Difficulty
            int intDifficulty = MMLib.GetConsoleMenu(new List<string> { "Easy - 4 pegs", "Medium - 6 pegs", "Hard - 8 pegs" });

            // Ask for maxturns
            int maxTurns = MMLib.GetConsoleInt("How many attempts (1 - 50) ", 1, 50);

            // Asses Max Pegs Based On User Selected Difficulty
            int maxPegs = 2 + (intDifficulty * 2);

            // Generate The Correct Answer
            List<int> answer = MMLib.GenerateAnswer(maxPegs);

            // c h e a t e r
            MMLib.Cheat(answer, pegList);

            // while loop if no end conditions are met
            bool gameWon = false;
            while (!gameWon && maxTurns != 0)
            {
                // User Attempt
                Attempt attempt = GetAttemptFromUser(maxPegs, allAttempts, maxTurns);

                // Check Attempt v Answer
                CheckAttempt(attempt, answer);

                // Add Attempt To List Of Attempts
                allAttempts.Add(attempt);

                // Check For Win
                if (attempt.CorrectAnswerCount == maxPegs)
                {
                    gameWon = true;
                }

                // Reduce Number of MaxTurns
                maxTurns--;


            }

            // If Won, Tell Player
            if (gameWon == true)
            {
                Console.WriteLine("Game Won!");
                MMLib.ShowAnswer(answer, pegList, "0");
            }
            //If lost, Tell Player & Show Answer
            if (gameWon == false && maxTurns == 0)
            {
                Console.WriteLine("You Lost.");
                MMLib.ShowAnswer(answer, pegList, "0");
            }
        }

        static Attempt GetAttemptFromUser(int maxPegs, List<Attempt> allAttempts, int maxTurns)
        {
            // Create Attempt
            Attempt attempt = new Attempt();

            // Get Colors Based On MaxPegs
            MMLib.GetColorOptions(maxPegs, pegList);

            // Loop of # of pegs they need to choose
            for (int i = 0; i < maxPegs; i++)
            {
                //clear console
                Console.Clear();

                //Display # of attempts left
                Console.WriteLine("Number of attempts left: {0}", maxTurns);

                //Show all previous attempts
                MMLib.ShowAttempts(allAttempts, pegList, "0");

                //Show pegs they have chosen already in this attempt
                MMLib.ShowChosenPegs(attempt, pegList);

                //Ask them to pick a peg color from a menu of options
                int chosenPeg = MMLib.GetConsoleMenu(MMLib.GetColorOptions(maxPegs, pegList)) - 1;

                //Add the chosen peg to the Attempt.AtemptList
                attempt.AttemptList.Add(chosenPeg);
            }
            //Return the attempt when done
            return attempt;
        }


        static void CheckAttempt(Attempt attempt, List<int> answer)
        {
            //Check the attempt.AttemptList to see if they got a match to the answer
            //If a peg is correct, increment the attempt.CorrectAnswerCount
            for (int i = 0; i < answer.Count; i++)
            {
                if (attempt.AttemptList[i] == answer[i])
                {
                    attempt.CorrectAnswerCount++;
                }
            }
        }
    }
}
