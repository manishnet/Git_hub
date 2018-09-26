using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPool1
{
    class Class1
    {
         public int ab = 10;
        int a = 10;
        class three
        {
           public void access()
            {
                Class1 obj = new Class1();
                obj.ab = 20;
            }
            
        }
    }
    class Class2
    {
      
        public void men()
        {
        Class1 obj1 = new Class1();
        obj1.ab = 20;
        }
    }

}
