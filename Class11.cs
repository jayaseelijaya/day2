using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Class11
    {
  
            static void Main(string[] args)
        {
            string inputstr, reversestr = string.Empty;
            Console.Write("Enter a string : ");
            inputstr = Console.ReadLine();
            if (inputstr != null)
            {
                for (int i = inputstr.Length - 1; i >= 0; i--)
                {
                    reversestr += inputstr[i].ToString();
                }
                if (reversestr == inputstr)
                {
                    Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", inputstr, reversestr);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", inputstr, reversestr);
                }
            }
            Console.ReadLine();
        }
    }
}
