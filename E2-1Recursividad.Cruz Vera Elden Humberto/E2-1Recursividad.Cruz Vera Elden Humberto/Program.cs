using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_1Recursividad.Cruz_Vera_Elden_Humberto
{
    public class Factoriales
    {
        public int Resultado = 0;

        public int Factorial(int FactMenor)
        {
            if (FactMenor == 0)
            {
                return 1;
            }

            Resultado = FactMenor * Factorial(FactMenor - 1);
            return Resultado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch tiempo = new Stopwatch(); tiempo.Start();

            Factoriales facto = new Factoriales();
            
            Console.WriteLine("El factorial de 6 es: {0}", facto.Factorial(6));

            tiempo.Stop();
            Console.WriteLine("\nTiempo de ejecución del programa: {0}", tiempo.Elapsed.ToString());
            Console.Write("\nPresione una tecla para salir ");
            Console.ReadKey();
        }
    }
}
