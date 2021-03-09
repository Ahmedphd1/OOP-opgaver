using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bil
    {

        private string mærke { get; set; }
        public int alder { get; set; }

        public string returnmærke()
        {
            return mærke;
        }
    }
}
