using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadnie_domowe_nr_2_tydzień_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadnie: Napisz Program tworzacy 3 zmienne z jedną literą");
            Console.WriteLine("Wypisz je w odwrotnej kolejności");

            char Letter1 = 'A';
            char Letter2 = 'B';
            char Letter3 = 'C';

            Console.WriteLine($"{Letter3};{Letter2};{Letter1}");
                                            

        }
    }
}
