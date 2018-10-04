using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PE_2.Cruz_Vera_Elden_Humberto
{
    public class Recursividad
    {
        public int RecuMenor(int [] ArregloNumeros, int Cantidad, int Menor)
        {
            if (Cantidad == 0)
            {
                if (Menor > ArregloNumeros[Cantidad])
                    return ArregloNumeros[Cantidad];
                
                else
                    return Menor;
            }

                if (Menor > ArregloNumeros[Cantidad])
                    return RecuMenor(ArregloNumeros, Cantidad - 1, ArregloNumeros[Cantidad]);
                
                else
                    return RecuMenor(ArregloNumeros, Cantidad - 1, Menor);
        }

        public int RecuMayor(int[] ArregloNumeros, int Cantidad, int Mayor)
        {
            if (Cantidad == 0)
            {
                if (Mayor < ArregloNumeros[Cantidad])     
                    return ArregloNumeros[Cantidad];
                
                else
                    return Mayor;
            }

                if (Mayor < ArregloNumeros[Cantidad])
                    return RecuMayor(ArregloNumeros, Cantidad - 1, ArregloNumeros[Cantidad]);

                else
                    return RecuMayor(ArregloNumeros, Cantidad - 1, Mayor);  
        }

        public int RecuAlReves(int [] ArregloNumeros, int Cantidad)
        {
            if (Cantidad > -1)
            {
                Console.WriteLine(ArregloNumeros[Cantidad]);
                return RecuAlReves(ArregloNumeros, Cantidad - 1);
            }

            else
                return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Cantidad;
                int[] ArregloNumeros;
                int Aux;
                int Aux2;

                Console.Write("Ingrese la cantidad de números que desea para este programa: ");
                Cantidad = Int16.Parse(Console.ReadLine());

                ArregloNumeros = new int[Cantidad];

                Console.WriteLine();

                for (int Contador = 0; Contador < Cantidad; Contador++)
                {
                    Console.Write("Ingrese un número: ");
                    ArregloNumeros[Contador] = Int32.Parse(Console.ReadLine());
                }

                Recursividad recu = new Recursividad();

                int Menor = ArregloNumeros[Cantidad - 1];
                Stopwatch tiempo1 = new Stopwatch(); tiempo1.Start();

                Aux = recu.RecuMenor(ArregloNumeros, Cantidad - 1, Menor);
                tiempo1.Stop();

                Console.WriteLine("\nEl número minimo es: {0}", Aux);
                Console.WriteLine("El tiempo de ejecución es: {0}", tiempo1.Elapsed.ToString());

                int Mayor = ArregloNumeros[Cantidad - 1];
                Stopwatch tiempo2 = new Stopwatch(); tiempo2.Start();
               
                Aux2 = recu.RecuMayor(ArregloNumeros, Cantidad - 1, Mayor);
                tiempo2.Stop();

                Console.WriteLine("\nEl número maximo es: {0}", Aux2);
                Console.WriteLine("El tiempo de ejecución es: {0}", tiempo2.Elapsed.ToString());

                
                Console.WriteLine("\nLa sucesión al reves es: ");
                Stopwatch tiempo3 = new Stopwatch(); tiempo3.Start();
                recu.RecuAlReves(ArregloNumeros, Cantidad - 1);
                tiempo3.Stop();

                Console.WriteLine("El tiempo de ejecución es: {0}", tiempo3.Elapsed.ToString());
            }

            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }

            finally
            {
                Console.Write("\nGracias por usar el programa, presione una tecla para salir ");
                Console.ReadKey();
            }
          

            



        }
    }
}
