using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class alder : Bil
    {
        public Nullable<int> værdi { get; set; }

        public alder(DateTime årgang)
        {
            int somealder = 2020 - Convert.ToInt32(årgang.ToString("yyyy"));

            alder = somealder;

            værdi = somealder;
        }
    }
}
