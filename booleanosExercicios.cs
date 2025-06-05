using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    internal class booleanosExercicios
    {
        public static void Main(string[] args)
        {
            bool CsharpÉbom = true;
            bool dmcSerie = false;
            Console.WriteLine("isso é verdade?");   
            Console.WriteLine(CsharpÉbom);
            Console.WriteLine("isso é verdade?");
            Console.WriteLine(dmcSerie);

            int NumX = 10;
            int NumY = 9;
            Console.WriteLine($"o valor de \"X\" é {NumX} e o de \"Y\" é {NumY}");
            Console.WriteLine("X É maior que Y?");
            Console.WriteLine(NumX >NumY);
            Console.WriteLine("Y é maior que X?");
            Console.WriteLine(NumY > NumX);
        }
    }
}
