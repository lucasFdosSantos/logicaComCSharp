using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    internal class Continuar
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
