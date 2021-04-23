using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class swap

    {

        void Swap(int a, int b)

        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Before swap a= " + a + " b= " + b);

        }
        static void Main()
        {
            swap class2 = new swap();
            int a = 4, b = 5;
            class2.Swap(a, b);
            Console.Write("After swap a= " + a + " b= " + b);
            Console.ReadLine();
        }
    }
}



