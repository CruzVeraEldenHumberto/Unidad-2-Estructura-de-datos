using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_1.Cruz_Vera_Elden_Humberto
{
    public class Factoriales
    {
        public int Factorial = 1;

        public int Calcular()
        {
            for (int Contador = 1; Contador < 7; Contador++)
                Factorial = Factorial * Contador;

            return Factorial;
        }

        public void Mostrar()
        {
            Console.WriteLine("El factorial de 6 es: {0}", Calcular());
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch tiempo = new Stopwatch(); tiempo.Start();
            Factoriales fact = new Factoriales();
            fact.Mostrar();
            tiempo.Stop();

            Console.WriteLine("\nTiempo de ejecución del programa: {0}", tiempo.Elapsed.ToString());
            Console.Write("\nPresione una tecla para salir ");
            Console.ReadKey();
        }
    }
}
