using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_3_Raso_Padilla_Jose_Manuel
{
    public class Ordenamiento
    {
        public void RealizaOperacion()
        {
            int cantidad;
            string cadena;
            int contador2 = 0;
            Console.Write("Ingrese el numero de elementos en la sucesion: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidad];
            Console.Write("\n\n");
            CicloIngreso();
            Console.Write("\nOrden original:\n");
            DespliegaNumeros(contador2, numeros);
            OrdenamientoNumeros(contador2, numeros);
            Console.ReadLine();

            void CicloIngreso()
            {
                cadena = "\n\nOrden original: ";
                for (int contador = 0; contador < cantidad; contador++)
                {
                    Console.Write("Ingrese elemento {0} de la sucesion: ", (contador + 1));
                    numeros[contador] = Convert.ToInt32(Console.ReadLine());
                    cadena = cadena + "\n" + Convert.ToString(contador + 1) + ".- " + Convert.ToString(numeros[contador]);
                }
            }
        }

        public void OrdenamientoNumeros(int contador, int[] numeros)
        {
            if (contador < (numeros.Length / 2))
            {
                int Auxiliar = 0;
                Auxiliar = numeros[contador];
                numeros[contador] = numeros[(numeros.Length - (contador + 1))];
                numeros[(numeros.Length - (contador + 1))] = Auxiliar;
                contador++;
                OrdenamientoNumeros(contador, numeros);
            }
            else
            {
                contador = 0;
                Console.Write("\nNuevo orden: \n");
                DespliegaNumeros(contador, numeros);
            }
        }

        public void DespliegaNumeros(int contador, int[] numeros)
        {
            if (contador < numeros.Length)
            {
                Console.Write("{0}.- {1}\n", (contador + 1), numeros[contador]);
                contador++;
                DespliegaNumeros(contador, numeros);
            }
        }
    }
}
