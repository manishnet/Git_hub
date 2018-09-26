using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    public class Class6
    {
        public int a = 10;
        public static int b = 10;
        int[] array = {  5,21, 15, 25, 35 };
        public void getHCF()
        {
           for(int i=0;i<array.Length-1;i++)
            {
                var h = HCF(array[i], array[i + 1]);
                array[i + 1] = h;
            }

        }

        public int HCF(int a, int b)
        {
            if(a%b==0)
            {
                return b;
            }
            else
            {
                return (HCF(b, a % b));
            }

        }

        public int gethcf1()
        {
            bool value=false;
            int val = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= array.Length - 1; j++)
                {
                    if (array[j] % i == 0)
                    {
                        value = true;
                    }
                    else
                    {
                        value = false;
                        break;
                    }
                }
                if(value)
                {
                    val = i;
                }
               
            }
            return val;
        }
    }

}



