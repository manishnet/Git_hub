using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    public class Class1
    {

        static int b = 10;
        internal static int a;
        static Class1()
        {
            a = 10;
            b = 30;
        }
    
        public static void print()
        {
            Console.WriteLine("test protected");
            b = 30;
        }
        public static void print1()
        {
            Console.WriteLine("test print1");
     
        }


    }
}
