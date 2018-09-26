using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class A
    {
        int a = 10;
        public virtual void print()
        {
            Console.WriteLine("Class A");
        }
    }
    class B:A
    {
        int b = 20;
        public override void print()
        {
            Console.WriteLine("Class B");
        }
        public void add()
        {
            Console.WriteLine(10 + 10);
        }
    }
    class C:B
    {
        int c = 20;
        public override void print()
        {
            Console.WriteLine("Class C");
        }
    }
}
