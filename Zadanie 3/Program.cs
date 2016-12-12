using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    public static class ExtensionMethods
    {
        public static double Calculate(this List<double> list,int p)
        {
            double sum = 0 ,numberOfElements=0;

            if (list.Count == 0)
                throw new Exception();
            else
            {
                foreach (var number in list)
                {
                    if(number>p)
                    {
                        sum += number;
                        numberOfElements++;
                    }
                }
            }

            return sum/numberOfElements;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region variables
            var lista = new List<double>();
            Random losowanie = new Random();
            #endregion

            for(int x=0; x<10;x++)
            {
                lista.Add(losowanie.Next(0, 9));
                Console.Write($"{lista[x]} ");
            }

            Console.WriteLine("\n\nPodaj parametr p:");

            try
            {
                Console.WriteLine($"\nWynik to {lista.Calculate(Convert.ToInt32(Console.ReadLine()))}");
            }
            catch
            {
                Console.WriteLine("Tablica nie może być pusta");
            }
        }
    }
}
