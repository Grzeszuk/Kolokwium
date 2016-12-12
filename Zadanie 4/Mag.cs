using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Mag : AbstractClass
    {
        #region variables
        private readonly int health;
        private readonly double mana;
        #endregion

        public Mag(bool gracz)
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
                Console.WriteLine("Podaj ilość many:");
                mana = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            else
            {
                health = 80;
                mana = 40;
            }
        }

        public override double Atakuj() => mana / 2;

        public override double Obrona() => health;
    }
}
