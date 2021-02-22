using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<A,B>
    {
        A[] keys;//numbers
        B[] values;//students
        A[] tempKeys = new A[0];
        B[] tempValues = new B[0];

        public MyDictionary()
        {
            keys = new A[0];
            values = new B[0];

        }

        public void Add(A item1,B item2)
        {
            Console.WriteLine(item1 + " numaralı öğrenci olan " + item2 + " sisteme eklendi.");
        }



    }
}
