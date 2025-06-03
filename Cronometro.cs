using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmCSharp
{
    internal class Cronometro
    {
        public static void Main(string[] args)
        {
            for (int H = 0; H < 25; H++)
            {
                for (int M = 0; M < 60; M++)
                {
                    for (int S = 0; S < 60; S++)
                    {
                        Console.WriteLine($"{H:D2}:{M:D2}:{S:D2}");
                        Thread.Sleep(1000);
                    }
                    
                }

            }
            {

            }

        }
    }
}
