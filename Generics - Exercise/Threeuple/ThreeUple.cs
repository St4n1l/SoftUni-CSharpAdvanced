using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    class ThreeUple<T1,T2,T3>
    {
        public ThreeUple(T1 first, T2 second, T3 third)
        {
            Type1 = first;
            Type2 = second;
            Type3 = third;
        }
        public T1 Type1 { get; set; }
        public T2 Type2 { get; set; }
        public T3 Type3 { get; set; }

    }
}
