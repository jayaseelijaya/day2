using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Class12
    {
        static void Main()
        {

            int count = 0;
            Console.WriteLine("Input a string:");
            string input  = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'A' || input[i] == 'e' || input[i] == 'E' || input[i] == 'i' || input[i] == 'I' || input[i] == 'o' || input[i] == 'O' || input[i] == 'u' || input[i] == 'U')

                {
                    count++;
                }

            }
            Console.WriteLine("Number of vowels in the string:{0}", count);
            Console.ReadLine();
        }
    }
}