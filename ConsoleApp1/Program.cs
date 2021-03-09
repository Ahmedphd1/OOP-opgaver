using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi nyaudi = new Audi("bmw");

            nyaudi.printproperties();
            nyaudi.printproperties("bilen er skadet");
        }
    }
}
