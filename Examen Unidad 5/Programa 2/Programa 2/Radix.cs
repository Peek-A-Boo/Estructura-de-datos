using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_2
{
    class Radix
    {
        private int ObtenerMaximo(List<int> Numeros) //Metodo para obtener el valor mas alto
        {
            int maximo = Numeros[0];

            for (int contador = 0; contador < Numeros.Count; contador++) //Compara todos los numeros para conseguir el mas alto
            {
                if (Numeros[contador] > maximo)
                    maximo = Numeros[contador];
            }

            return maximo; //regresa el elemento mas alto
        }

        private void contarOrdenamiento(List<int> Numeros, int exponente)
        {
            List<int> Salida = new List<int>(); //Lista de salida que es el que reemplazara el no ordendo
            int contador = 0;
            int[] conteo = new int[10]; //Lista donde se almacenan los digitos significativos de la izquierda

            for (int contadorLlenar = 0; contadorLlenar < 10; contadorLlenar++) //Primero llena los digitos en 0
            {
                conteo[contadorLlenar] = 0;
            }

            for (int contadorLlenar = 0; contadorLlenar < 80; contadorLlenar++) //llena la lista de salida
            {
                Salida.Add(0);
            }

            //guarda las apariciones de conteo en contador
            for (contador = 0; contador < Numeros.Count; contador++)
            {
                conteo[(Numeros[contador] / exponente) % 10]++;
            }

            for (contador = 1; contador < 10; contador++)
            {
                conteo[contador] = conteo[contador] + conteo[contador - 1];
            }

            //LLena la lista de salida
            for (contador = Numeros.Count - 1; contador >= 0; contador--)
            {
                Salida[conteo[(Numeros[contador] / exponente) % 10] - 1] = Numeros[contador];
                conteo[(Numeros[contador] / exponente) % 10]--;
            }
            //Reemplaza la lista no ordenada con la ordenada
            for (contador = 0; contador < Numeros.Count; contador++)
            {
                Numeros[contador] = Salida[contador];
            }
        }

        public void OrdenamientoRadix(List<int> Numeros) //Metodo de ordenamiento radix
        {
            int maximo = ObtenerMaximo(Numeros); //Obtiene el valor mas alto

            //Realiza el contarOrdenamiento por cada exponente 
            for (int exponente = 1; maximo / exponente > 0; exponente = exponente * 10)
            {
                contarOrdenamiento(Numeros, exponente);
            }

            Console.ReadLine();

        }
    }
}
