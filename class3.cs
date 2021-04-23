using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class class3

    {

        void swap(int a, int b)

        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Before swap a= " + a + " b= " + b);

        }


        static void Main()
        {
            class3 class2 = new class3();
            int a = 4, b = 5;
            class2.swap(a, b);
            Console.Write("After swap a= " + a + " b= " + b);
            Console.ReadLine();
        }

    }
}
  
    


