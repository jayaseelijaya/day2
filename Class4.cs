using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Class4
    {
        static void Main()
        {
            int result;
            int.TryParse("jaya", out result);
            if (result == 0)
                {
                Console.WriteLine("number");

            }
            else
            {
                Console.WriteLine("not a number");
               
            }
        }
    }
}
