using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less14
{
    class Program
    {
        static void Main(string[] args)
        {
            WileDuck wd = new WileDuck("WD");
            HomeDuck hd = new HomeDuck("HD");

            DuckFly(wd);
            DuckFly(hd);
        }

        public static void DuckFly(Duck duck)
        {
            duck.Fly();
        }
    }


}
