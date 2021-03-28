using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Singleton obiekt1 = Singleton.GetObject();
            Singleton obiekt2 = Singleton.GetObject();

            
            if (obiekt1 == obiekt2)
            {
                Console.WriteLine("są identyczne");
            }
            else
            {
                Console.WriteLine("są różne");
            }

        }
    }

    public sealed class Singleton
    {
        private static Singleton obiekt;

     
        private Singleton() { }

       
        public static Singleton GetObject()
        {
            if (obiekt == null)
            {

                obiekt = new Singleton();
            }
            
            return obiekt;
        }
    }
}