using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Motorkøretøj
    {
        public string thismotor { get; set; }

        public Motorkøretøj(string motor, DateTime SynDato)
        {
            thismotor = motor;
        }
    }
}
