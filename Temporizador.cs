using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace LogicaEmCSharp
{
    internal class Temporizador
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temporiador");
            Console.WriteLine("digite as horas(maximo 24)");
            int H = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("digite os minutos(maximo 60)");
            int M = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("digite os segundos(maximo 60)");
            int S = Convert.ToInt16(Console.ReadLine());

            for (int h = H; h >= 0; h-- )
            {
                for (int m = (h == H ? M : 59); m >= 0; m--)
                {
                    for (int s = ( h == H && m == M ? S : 59); s >= 0; s--)
                    {
                        Console.WriteLine($"{h:D2}:{m:D2}:{s:D2}");

                        Thread.Sleep(1000);
                    }
                }
            }

        }
    }
}
