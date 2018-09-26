using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessModifier objAccessModifier = new AccessModifier();
            objAccessModifier.Func1();
         Class6 obj6 = new Class6();
            obj6.a = 10;
            Class6.b = 20;
            obj6.gethcf1();
            obj6.getHCF();
            A objb = new B();
            
            // C objC = new B() ;
            objb.print();
            A objA = new C();
            objA.print();
           
            Class4 onjClass4 = new Class4();
            onjClass4.print();
            Read obj = new Read();
            Read obj1 = new Read(10);
            Class1.print();
            Class1.print1();
            Console.WriteLine(Class1.a);
            //Console.ReadLine();
            TestGenericList on = new TestGenericList();
            on.dil();
           // DelegateExample objdee = new DelegateExample();
            areaDelegate objdel = delegate(int x) {return  2 * x; };
            objdel(10);

            Func<int, double> area = r => r * r;

            double va = area(10);
            Action<string> tt = e => Console.Write("test action");

            Console.WriteLine(objdel.Invoke(10).ToString());
            Console.ReadLine();
        }
    }

 class Read
   {
        const int a = 10;
        readonly int b = 15;
     
           
        
   public  Read()
       {
           b = 25;
       }
    public Read(int c)
    {
        b = c;
    }


   }
}
