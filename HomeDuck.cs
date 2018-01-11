using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less14
{
    class HomeDuck : Duck
    {
        public HomeDuck(string name) : base(name)
        {

        }
        public override void Fly()
        {
            Console.WriteLine($"{Name} I can't fly!");
        }
    }
}
