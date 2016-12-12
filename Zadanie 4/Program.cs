using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hero = new List<AbstractClass>();

            Console.WriteLine("Wybierz klase postaci (mag/wojownik): ");
            string klasa = Console.ReadLine().ToLower();

            if(klasa=="mag")
            {
                Hero.Add(new Mag(true));
                Hero.Add(new Wojownik(false));
            }
            else
            {
                Hero.Add(new Wojownik(true));
                Hero.Add(new Mag(false));
            }

            double mageHealth = Hero[0].Obrona();
            double warriorHealth = Hero[1].Obrona();

            while (true)
            {
                if (mageHealth > 0)
                {
                    Console.WriteLine($"Mag zaatakował za {Hero[0].Atakuj()}");
                    warriorHealth -= Hero[0].Atakuj();
                }

                if (warriorHealth > 0)
                {
                    Console.WriteLine($"Wojownik zaatakował za {Hero[1].Atakuj()}");
                    mageHealth -= Hero[1].Atakuj();
                }

                Thread.Sleep(500);

                if (warriorHealth == 0 || mageHealth == 0)
                {
                    break;
                }

            }

            if(mageHealth>0 && mageHealth>warriorHealth)
            {
                Console.WriteLine("\nWygrał Mag!!!");
            }
            else
            {
                Console.WriteLine("\nWygrał Wojownik!!!");
            }

        }
    }
}
