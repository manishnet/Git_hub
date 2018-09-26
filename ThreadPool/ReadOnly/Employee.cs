using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
   public  class Employee
    {
        
       public Employee(string name, int id)
        {
            ID = id;
            Name = Name;
        }

        public string Name { get; set; }
        public int ID { get; set; }
    }
}
