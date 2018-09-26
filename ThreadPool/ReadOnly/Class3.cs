using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class Class3
    {
        public virtual void print ()
    {
        int[] array={};
            for(int a=0;a<=10;a++)
            {
                array[array.Length]=a;
            }
    }

    }
    class Class4:Class3
    {
        public virtual void print()
        {
            int[] array = { 5, 2, 5, 8, 3, 8, 1, 7 };
            int[] array1 = new int[array.Length];
            int temp = 0;
            for (int a = 0; a < array.Length; a++)
            {
                for (int b = a+1; b < array.Length; b++)
                {
                    if (array[a] == array[b])
                    {
                        array1[a] = array[a];
                        temp = array[a];

                    }
                    else
                    {
                        if (temp != array[a])
                        {
                            array1[a] = array[a];
                            

                        }
                        
                    }
                }

           //    var duplicates = array
           //.GroupBy(p => p)
           //.Where(g => g.Count() > 1)
           //.Select(g => g.Key);
            }
            Array.Sort(array1);
        }
    }
}
