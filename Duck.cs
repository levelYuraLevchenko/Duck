using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less14
{
    public class Duck 
    {
        public string Name { get; set; }

        public Duck(string name)
        {
            Name = name;
        }
        public virtual void Fly()
        {
            //Console.WriteLine();
        }
    }
}
