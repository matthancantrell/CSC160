using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class DataTypes
    {
        public static void Execute()
        {
            short shortNum = 32767; //12 bits
            int intNum = 10; // 32 bits
            uint uintNum = 50; // 32 bits
            long longNum = 99999; // 64 bits
            float floatNum = 10.5f; //4 bytes
            double doubleNum = 500.4; // 8 bytes
            decimal decimalNum = 602.25M; // 16 bytes

            Console.WriteLine("short min {0}", short.MinValue);
            Console.WriteLine("short max {0}", short.MaxValue);
            Console.WriteLine();

            Console.WriteLine("int min {0}", int.MinValue);
            Console.WriteLine("int min {0}", int.MinValue);
            Console.WriteLine();

            Console.WriteLine("uint min {0}", uint.MinValue);
            Console.WriteLine("uint min {0}", uint.MinValue);
            Console.WriteLine();

            Console.WriteLine("long min {0}", long.MinValue);
            Console.WriteLine("long min {0}", long.MinValue);
            Console.WriteLine();

            Console.WriteLine("float min {0}", float.MinValue);
            Console.WriteLine("float min {0}", float.MinValue);
            Console.WriteLine();

            Console.WriteLine("double min {0}", double.MinValue);
            Console.WriteLine("double min {0}", double.MinValue);
            Console.WriteLine();

            Console.WriteLine("decimal min {0}", decimal.MinValue);
            Console.WriteLine("decimal min {0}", decimal.MinValue);
            Console.WriteLine();

            char c = 'A';
            Console.WriteLine("Char is: {0}", c);
            Console.WriteLine("IsDigit: {0}", char.IsDigit(c));
            Console.WriteLine("IsLetter: {0}", char.IsLetter(c));
            Console.WriteLine(char.IsNumber(c));

            string str = "Stuff";
        }
    }
}
