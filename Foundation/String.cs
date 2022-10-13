using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class String
    {
        public static void Start()
        {
            string strName = Console.ReadLine();
            Console.WriteLine("\nV1 - Hello " + strName + "! Happy to meet you!\n");
            Console.WriteLine($"V2 - Hello {strName} you're awesome!");
            Console.WriteLine("V3 - Hello {0} glad to meet you!", strName);

            string strRandom = "Neumont College of Computer Science";
            Console.WriteLine(("Length: {0}", strRandom.Length));
            Console.WriteLine("Contains 'of' : {0}", strRandom.Contains("of"));

            int indexOf = strRandom.IndexOf("of");
            Console.WriteLine("IndexOf position: {0}", indexOf != 1 ? indexOf.ToString() : "Not Found!");

            Console.WriteLine("Remove: {0}", strRandom.Remove(indexOf, 3));
            Console.WriteLine(strRandom);

            // StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello There. ");
            sb.Append("General Kenobi");
            Console.WriteLine($"StringBuilder: {sb.ToString()}");
        }
    }
}
