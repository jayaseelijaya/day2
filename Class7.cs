using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Dog
    {
        public void speak()
        {
         Console.WriteLine("BARK");
        }
    }
    class Class7
    {
    static void Main()
        {
            object o = new Dog();
            Dog dog = o as Dog;
            if (dog != null)
                dog.speak();
            Console.ReadLine();
        }
    }
}

