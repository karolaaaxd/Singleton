using System;

namespace FactoryMethod
{
    class Program
    {
        abstract class Ciasto
        {
            public abstract string Upiecz();


        }
        class Beza : Ciasto
        {
            public override string Upiecz()
            {

                return "Upieczona beza";

            }
        }


        class Murzynek : Ciasto
        {
            public override string Upiecz()
            {
                return "Upieczony murzynek";
            }
        }

        class FabrykaCiast
        {
            public Ciasto produkcjaCiastek(string about)
            {
                Ciasto ciastko = null;

                if (about.Equals("Beza"))
                {
                    ciastko = new Beza();
                }
                else if (about.Equals("Murzynek"))
                {
                    ciastko = new Murzynek();
                }

                return ciastko;
            }

        }
        static void Main(string[] args)
        {

            FabrykaCiast producent = new FabrykaCiast();

            Console.WriteLine(producent.produkcjaCiastek("Beza").Upiecz());
            
            Console.WriteLine(producent.produkcjaCiastek("Murzynek").Upiecz());


        }
    }
}
