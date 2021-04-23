using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Class10
    {
    static void Main()
        {
            object str = "hello";
            char[] values = { 'h', 'e', 'l', 'l', 'o' };
            object str2 = new string(values);
            Console.WriteLine("using equality operator" + (str == str2));
            Console.WriteLine("using equals() method {0}", str.Equals(str2));
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
