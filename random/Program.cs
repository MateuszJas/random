using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random losuj = new Random();
            int x, a;
            x = losuj.Next(10); 
            Console.WriteLine("Liczba wylosowana, zgaduj!");

            do
            {
                Console.WriteLine("Podaj swoją liczbę");
                a = System.Convert.ToInt16(Console.ReadLine());

                if (a > x)
                    Console.WriteLine("Za dużo!");
                if (a < x)
                    Console.WriteLine("Za mało!");

            } while (a != x);

            Console.WriteLine("Wygrałeś");
            Console.ReadKey();  
        }
          
    }
}
