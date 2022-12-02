using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Generics
    {

        public static void Execute()
        {
            int i = 20;
            int o = 1;
            Swap(ref i, ref o);
            Console.WriteLine("I Value : {0}", i);
            Console.WriteLine("O Value : {0}", o);
        }

        static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
