using System.ComponentModel.Design;

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
                DrawBoard(board);

                int chooseRow, chooseCol;
                bool validInput = false;
                bool rowInput = false;
                bool colInput = false;
                bool boardInput = false;

                do
                {
                    // Get Input
                    do
                    {
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

                        if (board[chooseRow-1, chooseCol-1] == 0)
                        {
                            board[chooseRow-1,chooseCol-1] = playerSymbols[turn];
                            totalTurns++;

                            if (turn == 0)
                            {
                                turn++;
                            }
                            else
                            {
                                turn--;
                            }

                            DrawBoard(board);
                        }
                        else
                        {
                            Console.WriteLine("That section is already filled. Try Again.");
                        }

                    } while (!boardInput);
                    


                } while (!validInput);

                // Set Board Spot as Owned By Player

                // If CheckForWinner == true, break. (break = jump out of loop)

            } while (!boolDone);

            // If game was tie, state that
            // If not a tie, declare winner
        }

        static bool CheckForWinner(char[,] board, char PlayerSymbol)
        {
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
                    Console.Write("|");
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
