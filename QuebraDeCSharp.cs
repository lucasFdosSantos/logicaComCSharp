using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    internal class QuebraDeCSharp
    {
        public static void Main(string[] args)
        {
            for (int Cookie = 0; Cookie < 10; Cookie++)
            {
                 
                if (new int[] {4, 5 , 6 }.Contains(Cookie))
                {
                    continue;

                }
                Console.WriteLine($"{Cookie} Cookies");
            }
        }
    }
}
