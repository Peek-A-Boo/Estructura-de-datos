using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3___Radix
{
    class Proceso
    {
        private int ObtenerMaximo(int[] Numeros, int longitud) //Metodo para obtener el valor mas alto
        {
            int maximo = Numeros[0]; 

            for (int contador = 0; contador < longitud; contador++) //Compara todos los numeros para conseguir el mas alto
            {
                if (Numeros[contador] > maximo)
                    maximo = Numeros[contador];
            }

            return maximo; //regresa el elemento mas alto
        }

        private void contarOrdenamiento(int[] Numeros,int longitud, int exponente)
        {
            int[] Salida = new int[longitud]; //Arreglo de salida que es el que reemplazara el no ordendo
            int contador = 0;
            int[] conteo = new int[10]; //Arreglo donde se almacenan los digitos significativos de la izquierda

            for (int contadorLlenar = 0; contadorLlenar < 10; contadorLlenar++) //Primero llena los digitos en 0
            {
                conteo[contadorLlenar] = 0;
            }

            //guarda las apariciones de conteo en contador
            for (contador = 0; contador < longitud; contador++)  
            {
                conteo[(Numeros[contador] / exponente) % 10]++;
            }

            for (contador = 1; contador<10;contador++)
            {
                conteo[contador] = conteo[contador] + conteo[contador - 1];
            }

            //LLena el arreglo de salida
            for (contador = longitud - 1; contador >= 0; contador--)
            {
                Salida[conteo[(Numeros[contador] / exponente) % 10] - 1] = Numeros[contador];
                conteo[(Numeros[contador] / exponente) % 10]--;
            }
            //Reemplaza el arreglo no ordenado con el ordenado
            for (contador=0;contador<longitud;contador++)
            {
                Numeros[contador] = Salida[contador];
            }
        }

        public void OrdenamientoRadix(int[] Numeros, int longitud) //Metodo de ordenamiento radix
        {
            int maximo = ObtenerMaximo(Numeros, longitud); //Obtiene el valor mas alto

            //Realiza el contarOrdenamiento por cada exponente 
            for(int exponente=1;maximo/exponente > 0; exponente=exponente*10)
            {
                contarOrdenamiento(Numeros, longitud, exponente);
            }
            //Imprime el arreglo ordenado
            foreach(int Numero in Numeros)
            {
                Console.Write("( {0} ) ", Numero);
            }

            Console.ReadLine();

        }


    }
}
