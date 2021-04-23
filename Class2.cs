using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Class2
    {
        static void Main(string[] args)
        {
            void checkoddeven(int i);
            Console.Write("Enter a Number : ");
            i = Console.Convert ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                checkoddeven()
                Console.Read();
                
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
                checkoddeven()
            }
        }
    }
}
