using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_primer_programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
using Syste

namespace Sentencias
{
    class SentenciaIf
    {
        public static void Main(string[] args)
        {
            int numeroEntero = int.Parse(Console.ReadLine());

            if (numeroEntero == 7)
            {
                Console.WriteLine("El número entero es 7.");
            }
            else if (numeroEntero < 0)
            {
                Console.WriteLine("El número entero es negativo.");
            }
            else
            {
                Console.WriteLine("El número entero no es ninguno de los casos programados.");
            }
        }
    }
}
