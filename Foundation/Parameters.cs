using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Parameters
    {
        public static void DoIt()
        {
            int intRef = 7;
            int[] ary = new int[] { 5, 6 };

            string strByVal = "Fred";
            RefTest clsRT = new RefTest();
            clsRT.x = 1;
            int intValue = 66;
            int[] ary2 = new int[2];
            ary.CopyTo(ary2, 0);

            ByValueRefTest(ref intRef, strByVal, ary2, clsRT, intValue);
            Console.WriteLine("int byRef: {0}", intRef);
            Console.WriteLine("String : " + strByVal);
            Console.WriteLine("ary[0] : {0}", ary[0]);
            Console.WriteLine("ary2[0] : {0}", ary2[0]);
            Console.WriteLine("clsRT.x: {0}", clsRT.x);
            Console.WriteLine("int value: {0}", intValue);
            defaultParam(69);
            //NamedFunction();
        }

        public static void ByValueRefTest(ref int xRef, string sVal, int[] ary, RefTest clsRefTest, int value)
        {
            xRef = xRef * xRef;
            sVal = "Fanny";
            ary[0] = 10;
            clsRefTest.x = 88;
            value = 42;
        }

        public class RefTest
        {
            public int x;
        }

        static void defaultParam(int n = 20)
        {
            Console.WriteLine("Default Param: {0}", n);
        }

        static void NamedFunction(int x, int y)
        {
            Console.WriteLine("Named Param: {0} - {1}", x, y);
        }
    }
}
