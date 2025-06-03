using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmCSharp
{
    internal class Faccat2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("caculadora de area de triangulo");
            Console.WriteLine("digite a base do triagulo");
            Boolean Base = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("digite a altura do triagulo");
            Boolean altura = Convert.ToBoolean(Console.ReadLine());
            Boolean area = (Base * altura) / 2;
        }
    }
}
