using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//С помощью класса GC вызвать изменение поколения любого вами созданного объекта вашего собственного класса.

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myNewObject = new MyClass();
            int i = GC.GetGeneration(myNewObject);
            Console.WriteLine("Current generation of object is {0}",i);
            GC.Collect();
            i = GC.GetGeneration(myNewObject);
            Console.WriteLine("Current generation of object is {0}", i);
            GC.Collect();
            i = GC.GetGeneration(myNewObject);
            Console.WriteLine("Current generation of object is {0}", i);
            Console.Read();
        }
    }
}
