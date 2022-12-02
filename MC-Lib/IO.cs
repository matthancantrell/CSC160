using System.Reflection.Metadata.Ecma335;

namespace MC_Lib
{
    public class IO
    {
        public static int GetConsoleInt(string message, int min, int max)
        {
            bool validInput = false;
            int input;
            do
            {
                Console.WriteLine("{0} : ", message);
                bool valid = int.TryParse(Console.ReadLine(), out input);

                if (valid)
                {
                    if (input <= max && input >= min)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try again.");
                }

            } while (!validInput);
            return input;
        }

        public static float GetConsoleFloat(string message, float min, float max)
        {
            bool validInput = false;
            float input = 0;
            do
            {
                Console.WriteLine("{0} : ", message);
                bool valid = float.TryParse(Console.ReadLine(), out input);

                if (valid)
                {
                    if (input <= max && input >= min)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try again.");
                }
            } while (!validInput);
            return input;
        }

        public static bool GetConsoleBool(string message)
        {
            bool validInput = false;
            bool input = false;
            do
            {
                Console.WriteLine("{0} : ", message);
                string inputS = Console.ReadLine();

                if (inputS.ToLower().Equals("false"))
                {
                    input = false;
                    validInput = true;
                }
                else if (inputS.ToLower().Equals("true"))
                {
                    input = true;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try again.");
                }
            } while (!validInput);
            return input;
        }

        public static char GetConsoleChar(string message)
        {
            bool validInput = false;
            char input;
            do
            {
                Console.WriteLine("{0} : ", message);
                bool valid = char.TryParse(Console.ReadLine(), out input);
                
                if (valid)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            } while (!validInput);
            return input;
        }

        public static string GetConsoleString(string message)
        {
            bool valid = false;
            string inputS;
            do
            {

                Console.WriteLine("{0} : ", message);
                inputS = Console.ReadLine();
                if (string.IsNullOrEmpty(inputS))
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                    valid = false;
                }
                else
                {
                    valid = true;
                }

            } while (!valid);

            return inputS;
        }

        public static int GetConsoleMenu(string[] items)
        {
            bool validInput = false;
            int input = -1;

            do
            {
                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine((i + 1) + " - " + items[i]);
                }

                Console.WriteLine("\nSelect an item within the presented range : ");
                bool valid = int.TryParse(Console.ReadLine(), out input);

                if (valid)
                {
                    if (input > items.Length || input < 1)
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }

            } while(!validInput);
            return input;
        }
    }
}