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

            // 'Do' loop to keep game going...
            do
            {
                int chooseRow, chooseCol;
                bool validInput = false;
                bool rowInput = false;
                bool colInput = false;

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

                        if (boolDone)
                        {
                            Console.WriteLine();
                            Console.WriteLine(playerNames[turn] + " wins!");
                        }

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
                } while (!validInput);

                // If CheckForWinner == true, break. (break = jump out of loop)
                if (totalTurns == 9)
                {
                    boolDone = true;
                }
            } while (!boolDone);

            // If game was tie, state that
            if (totalTurns >= 9 && !CheckForWinner(board, 'X') && !CheckForWinner(board, 'O'))
            {
                Console.WriteLine("");
                Console.WriteLine("Tie Game! Neither of you win.");
            }
            // If not a tie, declare winner
        }

        static bool CheckForWinner(char[,] board, char PlayerSymbol)
        {

            // Vertical Win
            // check for 3 in column
            for (int col = 0; col < board.GetLength(1); col++)
            {
                int symbolsInCol = 0;
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    if (board[row, col] == PlayerSymbol)
                    {
                        symbolsInCol++;
                        if (symbolsInCol == 3)
                        {
                            DrawBoard(board);
                            return true;
                        }
                    }
                    else
                    {
                        symbolsInCol = 0;
                    }
                }
            }

            // check for 3 in row
            for (int row = 0; row < board.GetLength(0); row++)
            {
                int symbolsInRow = 0;
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == PlayerSymbol)
                    {
                        symbolsInRow++;
                        if (symbolsInRow == 3)
                        {
                            DrawBoard(board);
                            return true;
                        }
                    }
                    else
                    {
                        symbolsInRow = 0;
                    }
                }
            }

            // Diagonal Win
            int x = 0;
            int y = 0;
            int match = 0;

            for (int i = 0; i < 3; i++)
            {
                if (board[x, y] == PlayerSymbol)
                {
                    x++;
                    y++;
                    match++;

                    if (match == 3)
                    {
                        DrawBoard(board);
                        return true;
                    }
                }
            }

            x = 0;
            y = 2;
            match = 0;
            for (int i = 0; i < 3; i++)
            {
                if (board[x, y] == PlayerSymbol)
                {
                    x++;
                    y--;
                    match++;
                }
                if (match == 3)
                {
                    DrawBoard(board);
                    return true;
                }
            }
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
