using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less14
{
    public class WileDuck : Duck
    {
        public WileDuck(string name) : base(name)
        {

        }
        public override void Fly()
        {
            Console.WriteLine($"{Name} I can fly!");
        }
    }
}
