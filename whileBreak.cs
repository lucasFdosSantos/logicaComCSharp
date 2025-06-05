using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    internal class whileBreak
    {
        public static void Main(string[] args)
        {
            int Cookie = 0;
            while (Cookie < 10)
            {
                Console.WriteLine(Cookie);Cookie++;
                if (Cookie == 4)
                {
                    break;
                }
            }
        }
    }
}
