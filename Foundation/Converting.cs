using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Converting
    {
        public static void DoIt()
        {
            // Casting & Converting
            // Implicit Conversion
            int intNum = 11453525;
            long longBigNum = intNum;
            var c = 'C';
            Console.WriteLine("var type: {0}", c.GetType());

            // Explicit Conversion
            // If conversion cannot be made without risk of losing data, the compiler requires an eplicit conversion
            double d = 1234.7;
            int i;
            i = (int)d;
            Console.WriteLine(i);

            string strNum = "5";
            int intResult = 0;
            intResult = int.Parse(strNum);
            Console.WriteLine("Parse: {0} {1}", intResult, intResult.GetType());
            bool bSuccess = int.TryParse(strNum, out intResult);
            Console.WriteLine(strNum + " converts to int? " + bSuccess);

            Console.WriteLine(isNumeric("6.7"));
        }

        public static bool isNumeric(string strNumber)
        {
            double doItNumber;
            return double.TryParse(strNumber, out doItNumber);
        }
    }
}
