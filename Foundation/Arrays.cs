using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Arrays
    {
        /// <summary>
        /// garray
        /// </summary>
        public static void Go()
        {
            int[] array1 = new int[3];

            // Defaults are set to 0. Other types *usually* default to NULL

            array1[0] = 55;
            array1[1] = 125;
            array1.SetValue(23, 2); // <- is just -> array1[2] = 23;

            // Implicitly knows it is an int array
            // vvv Both accomplish Same Goal vvv

            int[] array2 = { 1, 2, 3, 4 }; // Shorthand
            int[] array3 = new int[] { 1, 2, 3, 4 }; // Longhand

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("{0}", array1[i]);
            }

            foreach (int intNum in array1)
            {
                Console.WriteLine("{0} ", intNum);
                //break; // Exits Loop
                //continue; // Skips this iteration of said loop, ignoring code after;
            }

            string[,] alphabet = new string[2, 2] { { "A", "B" }, { "C", "D" } };
            for (int row = 0; row < alphabet.GetLength(0); row++)
            {
                for (int column = 0; column < alphabet.GetLength(1); column++)
                {
                    Console.Write("{0} ", alphabet[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            object[] stuff = new object[] { 10, "mafefe", 'X', 1.042f }; // All Variables Derrive From the Object Type

            // S E P A R A T I O N

            int[] aryNums = { 0, 1, 2, 3, 4, 5, 6 };
            WriteArray(aryNums);
            WriteArray(aryNums[..3]);
            WriteArray(aryNums[1..4]);
            WriteArray(aryNums[4..]);

            Array.Reverse(aryNums);
            WriteArray(aryNums);

            Array.Sort(aryNums);
            WriteArray(aryNums);

            Console.WriteLine("Find Index of 2: {0}", Array.IndexOf(aryNums, 2));

            Console.WriteLine("Numbers less than 4: ");
            WriteArray(Array.FindAll(aryNums, LessThanFour));

            static bool LessThanFour(int value)
            {
                return value < 4;
            }

            static void WriteArray(int[] values)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine("{0}", values[i]);
                }
                Console.WriteLine();
            }
        } 
    }
}
