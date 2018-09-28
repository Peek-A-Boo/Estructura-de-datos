using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_1_Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "Y";
            int[] numeros = new int[6];
            factorial Operacion = new factorial();
            do
            {
                Console.Clear();
                IngresaDatos();
                Console.Write("\n\n");
                Operacion.CalcularFactoriales(numeros);
                Console.Write("\nDesea realizar otra operacion? (Y/N)\n");
                opcion = Console.ReadLine().ToUpper();
            } while (opcion=="Y");
            Console.Write("Saliendo del programa. . .");
            Console.ReadLine();

            void IngresaDatos()
            {
                for (int contador = 0; contador < 6; contador++)
                {
                    Console.Write("Ingrese numero {0}: ", (contador + 1));
                    numeros[contador] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

    }

    class factorial
    {
        public factorial()
        {
        }

        public void CalcularFactoriales(int[] baseNum)
        {
            Stopwatch tiempos = Stopwatch.StartNew();
            for (int contador = 0; contador < 6; contador++) //Ciclo
            {
                Console.Write("{0}.-Factorial del numero {1} es: {2}\n", (contador + 1), baseNum[contador], CalculaFactorialFor(baseNum[contador]));
            }
            Console.Write("El tiempo de ejecucion del metodo FOR fue: {0}\n\n", tiempos.Elapsed.TotalMilliseconds);
            tiempos.Reset();
            tiempos.Start();
            for (int contador = 0; contador < 6; contador++) //Recursivo
            {
                Console.Write("{0}.-Factorial del numero {1} es: {2}\n", (contador + 1), baseNum[contador], CalculaFactorialRecursivo(baseNum[contador]));
            }
            Console.Write("El tiempo de ejecucion del metodo recursivo fue: {0}", tiempos.Elapsed.TotalMilliseconds);
            tiempos.Stop();
        }

        private int CalculaFactorialRecursivo(int baseNum)
        {
            if (baseNum <= 1)
                return 1;
            else
                return baseNum * CalculaFactorialRecursivo(baseNum -1 );
        }

        private int CalculaFactorialFor(int baseNum)
        {
            int resultado = 0;
            for (int contador=0;contador<=baseNum;contador++)
            {
                if (contador == 0)
                    resultado = 1;
                else
                    resultado = resultado * contador;
            }
            return resultado;
        }
    }
}
