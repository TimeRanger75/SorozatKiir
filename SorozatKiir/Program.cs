using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorozatKiir
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            //2.feladat
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //3.feladat
            Console.WriteLine("Adjon meg egy egynél nagyobb számot");
            int szam = int.Parse(Console.ReadLine());
            if (szam < 1)
            {
                Console.WriteLine("Hiba");
            }
            else
            {
                for (int i = 1; i <= szam; i++)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            //4. feladat
            Console.WriteLine("Adjon meg egy kezdő értéket");
            int kezdo = int.Parse(Console.ReadLine());
            Console.WriteLine("Adjon meg egy maximum értéket");
            int maximum = int.Parse(Console.ReadLine());
            if (maximum > kezdo)
            {
                for (int i = kezdo; i <= maximum; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                Console.WriteLine("Hiba");
            }
        }
    }
}
