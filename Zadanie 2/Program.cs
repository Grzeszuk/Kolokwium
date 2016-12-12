using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Matrix
    {
        #region variables
        double[,] table;
        private readonly int szerokosc;
        private readonly int wysokosc;
        #endregion

        public Matrix()
        {
            try
            {
                Console.WriteLine("Podaj szerokość tablicy: ");
                szerokosc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj wysokość tablicy: ");
                wysokosc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (szerokosc != wysokosc)
                    throw new Exception();

                table = new double[szerokosc, wysokosc];
                FillTable();
                Console.WriteLine($"\nSuma pod przekątną to {Sum()}");

            }
            catch
            {
                Console.WriteLine("Tablica nie jest kwadratowa");
            }

        }

        public void FillTable()
        {
            Random losowanie = new Random();

            for (int x = 0; x < wysokosc; x++)
            {
                for (int y = 0; y < szerokosc; y++)
                {
                    table[x, y] = losowanie.Next(0, 9);
                    Console.Write($"{table[x, y]} ");
                }
                Console.WriteLine();
            }
        }

        public double Sum()
        {
            double sum = 0;

            for(int x=0; x< wysokosc; x++)
                for(int y=0;y<x;y++)
                {
                    sum += table[x, y];
                }

            return sum;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Matrix objekt = new Matrix();
        }
    }
}
