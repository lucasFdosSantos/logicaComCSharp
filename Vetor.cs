using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp
{
    internal class Vetor
    {
        public static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            cars[0] = "Relampago marquinhos";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);

        }
    }
}