using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_2_Raso_Padilla_Jose_Manuel
{
    public class Mayor
    {
        
        public Mayor()
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

        public void Despliega(int contador, int mayor, int[] numeros)
        {
            if (contador > numeros.Length - 1)
            {
                Console.Write("\nEl numero mayor de la sucesion es: {0}", mayor);
            }
            else
            {
                if (numeros[contador] >= mayor)
                {
                    mayor = numeros[contador];
                    contador++;
                    Despliega(contador, mayor, numeros);
                }
                else
                {
                    contador++;
                    Despliega(contador, mayor, numeros);
                }
            }
        }

        ~Mayor()
        {

        }
    }
}
