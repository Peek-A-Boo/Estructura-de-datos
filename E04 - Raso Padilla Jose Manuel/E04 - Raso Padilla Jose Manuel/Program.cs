using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04___Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numeros = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int suma = 0;
                int contador;
                SumaNumeros4();
                SumaNumeros9();
                Console.ReadLine();

                void SumaNumeros4()
                {
                    for (contador = 0; contador < 4; contador++)
                    {
                        suma = numeros[contador] + suma;
                    }
                    Console.Write("La suma de los primeros 4 elementos es de: {0}\n\n", suma);
                    suma = 0;
                }
                void SumaNumeros9()
                {
                    for (contador = 0; contador < 9; contador++)
                    {
                        suma = numeros[contador] + suma;
                    }
                    Console.Write("La suma de los elementos 1 a 9 es de: {0}\n\n", suma);
                    suma = 0;
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error encontrado: {0}", ex);
            }
        }
    }
}
