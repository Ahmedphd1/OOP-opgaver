using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Audimodel
    {
        public double motorstørelse { get; set; }
        public DateTime årgang { get; set; }
        public string model { get; set; }
        public string farve { get; set; }

        internal bool Any(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
