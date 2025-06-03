using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmCSharp
{
    internal class Faccat1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um numero para descobri seu antecessor");
            int numI = Convert.ToInt16(Console.ReadLine());
            int antecessor = numI - 1;
            Console.WriteLine($"o antecessor de {numI} é {antecessor}");
        }
    }
}
