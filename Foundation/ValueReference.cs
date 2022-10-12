﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class ValueReference
    {
        public static void Engage()
        {
            int v1 = 10;
            int v2 = v1;
            v1 = 5;
            //Console.WriteLine("Value type v1: {0}", v1);
            //Console.WriteLine("Value type v2: {0}", v2);

            int[] ary1 = new int[] { 1, 2, 3 };
            int[] ary2 = ary1;
            //Console.WriteLine("Ref type v1: {0}", String.Join(", ", ary1));
            //Console.WriteLine("Ref type v2: {0}", String.Join(", ", ary2));

            ary1[0] = 5;
            //Console.WriteLine("Ref type v1: {0}", String.Join(", ", ary1));
            //Console.WriteLine("Ref type v2: {0}", String.Join(", ", ary2));

            Point p1 = new Point(10, 20);
            Point p2 = p1;

            p1.Write();
            p2.Write();

            p1.x = 200;

            p1.Write();
            p2.Write();
        }

        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Write()
            {
                Console.WriteLine("{0} - {1}", x, y);
            }
        }
    }
}
