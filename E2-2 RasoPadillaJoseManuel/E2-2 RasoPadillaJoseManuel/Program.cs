using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2_RasoPadillaJoseManuel
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "Y";
            double numero = 0;
            double[] resultado = new double[2] { 0, 0 };
            Fibonacci Operacion = new Fibonacci();
            do
            {
                Console.Clear();
                Console.Write("Ingrese numero de iteraciones: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\n");
                Operacion.CalcularFibonacci(numero,resultado);
                Console.Write("\nDesea realizar otra operacion? (Y/N)\n");
                opcion = Console.ReadLine().ToUpper();
            } while (opcion == "Y");
            Console.Write("Saliendo del programa. . .");
            Console.ReadLine();
        }
    }

    class Fibonacci
    {
        public Fibonacci()
        {
        }

        public void CalcularFibonacci(double num,double[] resultados)
        {
            Stopwatch tiempos = Stopwatch.StartNew();
            CalcularFibonacciFor(num,resultados);
            Console.Write("El tiempo de ejecucion del metodo FOR fue: {0}\n\n", tiempos.Elapsed.TotalMilliseconds);
            resultados[0] = 0;
            resultados[1] = 0;
            Console.Write("\n\n");
            tiempos.Reset();
            tiempos.Start();
            for(int contador=0;contador<num;contador++)
            {
                Console.Write("{0}.- {1}\n", (contador + 1), CalcularFibonacciRecursivo(contador));
            }
            Console.Write("El tiempo de ejecucion del metodo recursivo fue: {0}\n\n", tiempos.Elapsed.TotalMilliseconds);
            tiempos.Stop();
        }

        private double CalcularFibonacciRecursivo(double baseNum)
        {
            if (baseNum == 0)
            {
                return 0;
            }
            else if (baseNum == 1 || baseNum ==2)
            {
                return 1;
            }
            else
            {
                return CalcularFibonacciRecursivo(baseNum - 2) + CalcularFibonacciRecursivo(baseNum - 1);
            }
        }

        private void CalcularFibonacciFor(double baseNum, double[] resultados)
        {
            double suma = 0;
            for (int contador=0;contador<baseNum;contador++)
            {
                Console.Write("{0}.- {1}\n", (contador + 1), resultados[1]);
                if (contador==0)
                {
                    resultados[1] = resultados[1] + 1;
                }
                else
                {
                    suma = resultados[1] + resultados[0];
                    resultados[0] = resultados[1];
                    resultados[1] = suma;
                }
            }
        }
    }
}
