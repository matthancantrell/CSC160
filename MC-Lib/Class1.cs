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

            } while(!validInput);
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

                if (inputS.ToLower().Equals("false") || inputS.ToLower().Equals("true"))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try again.");
                }
            } while (!validInput);
            return input;
        }
    }
}