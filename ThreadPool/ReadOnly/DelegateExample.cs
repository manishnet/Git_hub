using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    delegate int areaDelegate(int a);
    public class DelegateExample
    {
        public int method1(int a)
        {
            return 2 * a;

        }
    }
}
