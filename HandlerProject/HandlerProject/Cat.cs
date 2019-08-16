using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerProject
{
    class Cat
    {
        private string name;
        public Cat(string name)
        {
            this.name = name;
        }

        public delegate void NoNameShoutEventHandler();
        public event NoNameShoutEventHandler NoNameShoutToMouse;
        public void NoNameShout()
        {
            Console.WriteLine("喵喵！你们的大魔王来了！");
            //if (NoNameShoutToMouse != null)
            //    NoNameShoutToMouse();
            NoNameShoutToMouse?.Invoke();//简化写法
        }


        public delegate void WithNameShoutEventHandler(object sender, CatShoutEventArgs e);
        public event WithNameShoutEventHandler WithNameShoutToMouse;
        public void WithNameShout()
        {
            Console.WriteLine("喵喵！我{0}大魔王又来了！", name);
            //if (WithNameShoutToMouse != null)
            //    WithNameShoutToMouse();
            CatShoutEventArgs eventArgs = new CatShoutEventArgs();
            eventArgs.Name = name;
            WithNameShoutToMouse?.Invoke(this, eventArgs);//简化写法
        }
    }
}
