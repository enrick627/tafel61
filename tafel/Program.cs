//Geef de tafels tot en met 10 van het ingegeven getal 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tafel
{
    class Program
    {
        static void Main(string[] args)
        {
            int TafeGEt, somGet=0;
            Console.WriteLine("geef het getal waar u de tafels van wilt hebben");
            TafeGEt = int.Parse( Console.ReadLine());

            for (int aantalGet = 1; aantalGet <= 10; aantalGet++)
            {
                somGet = TafeGEt * aantalGet;
                Console.WriteLine($"tafel {TafeGEt} * {aantalGet}={somGet}");
               
            }
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
