using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerProject
{
    class Mouse
    {
        private string name;
        public Mouse(string name)
        {
            this.name = name;
        }

        public void Run()
        {
            Console.WriteLine("不知道是哪只猫，我{0}先跑一步啦，从厨房跑~",name);
        }

        public void Run(object other, CatShoutEventArgs e)
        {
            Console.WriteLine("{0}又来了，我{1}先跑一步啦，从阁楼跑~", e.Name,name);
        }
    }
}
