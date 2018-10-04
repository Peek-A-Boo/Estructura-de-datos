using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_1_Raso_Padilla_Jose_Manuel
{
    public class Menor
    {
        public Menor()
        {

        }

        public void RealizaOperacion()
        {
            int cantidad;
            int contadorParametro = 0;

            Console.Write("Ingrese el numero de elementos en la sucesion: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidad];
            Console.Write("\n\n");
            CicloIngreso();
            Despliega(contadorParametro, numeros[0], numeros);
            Console.ReadLine();

            void CicloIngreso()
            {
                for (int contador = 0; contador < cantidad; contador++)
                {
                    Console.Write("Ingrese elemento {0} de la sucesion: ", (contador + 1));
                    numeros[contador] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Despliega(int contador, int menor, int[] numeros)
        {
            if (contador > numeros.Length - 1)
            {
                Console.Write("\nEl numero menor de la sucesion es: {0}", menor);
            }
            else
            {
                if (numeros[contador] <= menor)
                {
                    menor = numeros[contador];
                    contador++;
                    Despliega(contador, menor, numeros);
                }
                else
                {
                    contador++;
                    Despliega(contador, menor, numeros);
                }
            }
        }

        ~Menor()
        {

        }
    }
}
