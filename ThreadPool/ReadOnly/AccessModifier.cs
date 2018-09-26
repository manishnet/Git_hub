using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class AccessModifier
    {
        //public virtual void Func()
        // {
        //     Console.WriteLine("test");
        // }
        public int a = 10;
        public void Func1()
        {
            Console.WriteLine("test");
        }

        
    }

    
    class drive
    {
        public void objcrea()
        {
          AccessModifier objAccessModifier = new AccessModifier();
        objAccessModifier.Func1();
        }
      
    }
    
}
