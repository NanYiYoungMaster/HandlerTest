using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Tom");
            Mouse mouse1 = new Mouse("Jerry");
            Mouse mouse2 = new Mouse("Jack");
            cat.NoNameShoutToMouse += new Cat.NoNameShoutEventHandler(mouse1.Run);
            cat.NoNameShoutToMouse += new Cat.NoNameShoutEventHandler(mouse2.Run);
            cat.WithNameShoutToMouse += new Cat.WithNameShoutEventHandler(mouse1.Run);
            cat.WithNameShoutToMouse += new Cat.WithNameShoutEventHandler(mouse2.Run);

            Console.WriteLine("猫第一次叫，没带上自己的名字：");
            cat.NoNameShout();

            Console.ReadLine(); 

            Console.WriteLine("猫第二次叫，没带上自己的名字：");
            cat.WithNameShout();

            Console.ReadLine();
        }
    }
}
