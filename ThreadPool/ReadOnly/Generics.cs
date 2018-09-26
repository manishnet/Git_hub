using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    public class Generics<Test>
    {
        public void Add(Test input)
        {
            var ss = input;
        }
    }
    public class TestGenericList
    {
        
        public void dil()
        {
            // Declare a list of type int.
            Generics<int> list1 = new Generics<int>();
            list1.Add(10);

            // Declare a list of type string.
            Generics<string> list2 = new Generics<string>();
            list2.Add("Manish");
            // Declare a list of type ExampleClass.
            ExampleClass objExampleClass = new ExampleClass();
            Generics<ExampleClass> list3 = new Generics<ExampleClass>();
            list3.Add(objExampleClass);
        }
        public class ExampleClass
        {
            private int _ID;

            public int ID
            {
                get { return _ID; }
                set { _ID = value; }
            }
            private string _Name;

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
        }
    }
}

