using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Program
    {

        delegate Program createlist();

        static Program tilføjliste()
        {
            Program myprogram = new Program();

            //Audi instances
            Audimodel model1 = new Audimodel();
            DateTime dt = new DateTime(2000, 03, 03);
            model1.årgang = dt;
            model1.farve = "blå";

            Audimodel model2 = new Audimodel();
            DateTime dt2 = new DateTime(1994, 03, 03);
            model2.årgang = dt2;
            model2.farve = "rød";

            Audimodel model3 = new Audimodel();
            DateTime dt3 = new DateTime(2928, 03, 03);
            model3.årgang = dt3;
            model3.farve = "gul";

            Audimodel model4 = new Audimodel();
            DateTime dt4 = new DateTime(5948, 03, 03);
            model4.årgang = dt4;
            model4.farve = "sort";

            Audimodel model5 = new Audimodel();
            DateTime dt5 = new DateTime(7676, 03, 03);
            model5.årgang = dt5;
            model5.farve = "sort";

            myprogram.mylist.Add(model1);
            myprogram.mylist.Add(model2);
            myprogram.mylist.Add(model3);
            myprogram.mylist.Add(model4);
            myprogram.mylist.Add(model5);

            return myprogram;
        }

        public List<Audimodel> mylist { get; set; } = new List<Audimodel>();
        static void Main(string[] args)
        {
            createlist thislist = tilføjliste;

            Program audiliste = thislist();

            try
            {
                var query = audiliste.mylist.Where(element => element.farve == "sort").Select(element => element);

                foreach (var element in query)
                {
                    Console.WriteLine(element.model);
                    Console.WriteLine(element.årgang);
                    Console.WriteLine(element.farve);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("liste er tomt");
            }
            }
        }
    }