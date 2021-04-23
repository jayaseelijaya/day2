using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Callbyref


        {

            void Callbyref(ref int a,ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
                Console.WriteLine("Before swap a= " + a + " b= " + b);

            }
            static void Main()
            {
                Callbyref class2 = new Callbyref();
                int a = 4, b = 5;
                class2.Callbyref(ref a,ref b);
                Console.Write("After swap a= " + a + " b= " + b);
                Console.ReadLine();
            }
        }
}
