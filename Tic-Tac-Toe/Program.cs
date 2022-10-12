using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array Variables
            char[,] board = new char[3, 3];
            string[] playerNames = { "Player 1", "Player 2" };
            char[] playerSymbols = { 'X', 'O' }; // Letter O, not Number (0)

            // Indicates if game is done
            bool boolDone = false;

            int turn = 0; // Determines whose turn it is
            int totalTurns = 0; // Tracks number of turns to not exceed MAX (9)
            bool elGato = false; // Game is tie

            // 'Do' loop to keep game going...
            do
            {
                int chooseRow, chooseCol;
                bool validInput = false;
                bool rowInput = false;
                bool colInput = false;
                bool boardInput = false;

                DrawBoard(board); // Initially Draws The Empty Gameboard

                do
                {
                    // Get Input
                    do
                    {
                        Console.WriteLine("{0} Enter Row (1-3): ", playerNames[turn]);
                        bool validRow = int.TryParse(Console.ReadLine(), out chooseRow);

                        if (chooseRow <= 3 && chooseRow >= 1)
                        {
                            rowInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Row. Try again.");
                        }
                    } while (!rowInput);

                    do
                    {
                        Console.WriteLine("{0} Enter Column (1-3): ", playerNames[turn]);
                        bool validCol = int.TryParse(Console.ReadLine(), out chooseCol);

                        if (chooseCol <= 3 && chooseCol >= 1)
                        {
                            colInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Column. Try again.");
                        }
                    } while (!colInput);

                    if (rowInput && colInput)
                    {
                        validInput = true;
                    }

                    if (board[chooseRow - 1, chooseCol - 1] == 0)
                    {
                        board[chooseRow - 1, chooseCol - 1] = playerSymbols[turn];
                        totalTurns++;
                        boolDone = CheckForWinner(board, playerSymbols[turn]);

                        if (turn == 0)
                        {
                            turn++;
                        }
                        else
                        {
                            turn--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That section is already filled. Try Again.");
                    }


                    if (totalTurns >= 9)
                    {
                        Console.WriteLine("MaxTurns Reached!");
                    }
                } while (!validInput);

                // If CheckForWinner == true, break. (break = jump out of loop)
                if (totalTurns == 9)
                {
                    boolDone = true;
                }
            } while (!boolDone);

            // If game was tie, state that
            Console.WriteLine("Game Over!");
            // If not a tie, declare winner
        }

        static bool CheckForWinner(char[,] board, char PlayerSymbol)
        {
            int row = 0;
            int col = 0;
            int winCondition = 0;

            for (row = 0; row < board.GetLength(0); row++)
            {
                if (board[row, col] == PlayerSymbol)
                {
                    winCondition++;
                }
                else
                {
                    col++;
                }
            }

            for (col = 0; col < board.GetLength(0); col++)
            {
                if (board[row, col] == PlayerSymbol)
                {
                    winCondition++;
                }
                else
                {
                    col++;
                }
            }

            if (winCondition >= 3)
            {
                DrawBoard(board);
                if (PlayerSymbol == 'X')
                {
                    Console.WriteLine("Player 1 Wins!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Player 2 Wins!");
                    return true;
                }
            }
            else
            {
                winCondition = 0;
            }

            // Check Vertical
            // Check Horizontal
            // Check Diagonal

            // Use for Loop

            return false;
        }

        static void DrawBoard(char[,] board)
        {
            Console.WriteLine();
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    Console.Write(" {0} ", board[row, col]);
                    if (col < board.GetLength(1) - 1)
                    {
                        Console.Write("|");
                    }
                }

                Console.WriteLine();

                if (row < board.GetLength(1) - 1)
                {
                    // finish Console.WriteLine() stuff here...
                    Console.WriteLine("--------");
                }
            }
        }
    }
}
