using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2000, 03, 03);
            alder thisalder = new alder(dt);
            Bil thisbil = new Bil();
            Console.WriteLine(thisalder.alder);
            Console.WriteLine(thisbil.alder);
            Console.WriteLine(thisbil.returnmærke());
        }
    }
}
