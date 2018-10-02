using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2.Cruz_Vera_Elden_Humberto
{
    public class Fibonacci
    {
        public int Aux1=0;
        public int Aux2=0;

        public void Iterativo(int Cantidad, int Valor1, int Valor2)
        {
            for(int Contador =0; Contador<Cantidad; Contador++)
            {
                Aux1 = Valor1;
                Valor1 = Valor2;
                Valor2 = Valor2 + Aux1;
                Console.WriteLine(Aux1);
            }
        }

        public void Recursividad(int Cantidad, int Valor1, int Valor2)
        {
            if(Cantidad>0)
            {
                Console.WriteLine(Valor1);
                Aux1 = Valor1;
                Valor1 = Valor2;
                Valor2 = Valor2 + Aux1;
                Recursividad(Cantidad - 1, Valor1, Valor2);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Cantidad = 0;

                while(Cantidad <1)
                {
                    Console.Write("Cuantos numeros quiere de la sucesion: ");
                    Cantidad = Int16.Parse(Console.ReadLine());

                    if (Cantidad < 1)
                        Console.WriteLine("\nIngrese un valor minimo de 1");
                }

                Fibonacci fib = new Fibonacci();

                Stopwatch tiempo1 = new Stopwatch(); tiempo1.Start();
                fib.Iterativo(Cantidad, 0, 1);

                tiempo1.Stop();
                Console.WriteLine("\nTiempo de ejecución: {0}", tiempo1.Elapsed.ToString());

                Console.WriteLine();

                Stopwatch tiempo2 = new Stopwatch(); tiempo2.Start();
                fib.Recursividad(Cantidad, 0, 1);

                tiempo2.Stop();
                Console.WriteLine("\nTiempo de ejecución: {0}", tiempo2.Elapsed.ToString());
            }

            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            finally
            {
                Console.Write("Gracias por usar el programa, presione una tecla para salir ");
                Console.ReadKey();
            } 
        }
    }
}
