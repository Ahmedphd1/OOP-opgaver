using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    sealed class Audi : Bil
    {
        public string thisrim { get; set; }

        public Audi(string rim)
        {
            thisrim = rim;
        }

        public void printproperties()
        {
            Console.WriteLine(thisrim);
            Console.WriteLine(thismotor);
        }

        public void printproperties(string info)
        {
            Console.WriteLine(thisrim);
            Console.WriteLine(thismotor);
            Console.WriteLine(info);
        }
    }
}
