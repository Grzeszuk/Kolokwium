using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Wojownik : AbstractClass
    {
        #region variables
        private readonly int health;
        private readonly int damage;
        #endregion

        public Wojownik(bool gracz)
        {
            int skill = 120;

            if (gracz == true)
            {
                Console.Clear();
                Console.WriteLine("Masz do dyspozycji 120 punktów");
                Console.WriteLine("Podaj ilość życia:");
                health = Convert.ToInt32(Console.ReadLine());
                skill -= health;
                Console.Clear();
                Console.WriteLine($"Masz do dyspozycji {skill} punktów");
                Console.WriteLine("Podaj siłe ataku:");
                damage = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            else
            {
                health = 100;
                damage = 20;
            }       
        }

        public override double Atakuj() => damage;

        public override double Obrona() => health;
    }
}
