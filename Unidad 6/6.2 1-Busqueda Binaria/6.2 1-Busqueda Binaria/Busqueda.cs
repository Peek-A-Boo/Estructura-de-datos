using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_1_Busqueda_Binaria
{
    class Busqueda
    {
        int contador = 0;
        public void BuscarBinario(List<int> Numeros,int izquierda, int derecha,int elemento) //Metodo para realizar la busqueda binaria recursiva
        {
            if (contador==0) //Debido a que la busqueda binaria es para colecciones ordenadas primeramente llamo a la burbuja en la iteracion 1
            {
                BurbujitaBB(ref Numeros);
                contador = 1;
            }

            if(izquierda<derecha) //Si el valor de la izquierda es menor que el de la derecha realizara el siguiente proceso.
            {
                int medio = (izquierda + derecha) / 2; //El elemento medio dentro de la lista
                if(Numeros[medio]<elemento) //Si el elemento es mayor que mas de la mitad de la lista
                {
                    BuscarBinario(Numeros, medio + 1, derecha, elemento); //La nueva izquierda se vuelve el medio anterior+1 y se vuelve a llamar
                }
                else if(Numeros[medio]>elemento) //Si el elemento es mneor que mas de la mitad de la lista
                {
                    BuscarBinario(Numeros, izquierda, medio-1, elemento); //La nueva derecha se vuelve el medio anterior-1 y se vuelve a llamar
                }
                else //Si se encuentra el elemento
                {
                    Console.Write("\n\nElemento {0} encontrado en la posicion {1}\n\n", Numeros[medio], medio+1); //Se escribe el mensaje de encontrado
                    ImprimirLista(Numeros); //Imprime la lista de numeros
                }
            }
            else
            {
                Console.Write("Elemento inexistente dentro de la lista");  //Si no lo encuentra en ninguna iteracion significa que no existe
                ImprimirLista(Numeros); //Imprime la lista de numeros
            }
            Console.ReadLine();
        }

        private void BurbujitaBB(ref List<int> numeritos) //Metodo donde se realiza el metodo de la burbuja
        {
            int tempy = 0;
            for (int contador1 = 0; contador1 < numeritos.Count(); contador1++) //Primer ciclo donde se hace cuantas veces se repetira el otro for
            {
                for (int contador2 = 1; contador2 < numeritos.Count(); contador2++) //Segundo ciclo donde se hacen las comparaciones
                {
                    if (numeritos[contador2] < numeritos[contador2 - 1]) //Si el elemento con indice mayor es menor se invierten
                    {
                        tempy = numeritos[contador2]; //Variable temporal para guardar el numero que vamos a reemplazar
                        numeritos[contador2] = numeritos[contador2 - 1]; //Se asigna el valor al indice mayor el del indice anterior
                        numeritos[contador2 - 1] = tempy; //Guarda el elemento previamente cambiado;
                    }
                }
            }
        }

        private void ImprimirLista(List<int> Numeros) //Metodo para imprimir la lista
        {
            foreach(int numero in Numeros) //Por cada elemento del tipo int dentro de la lista realizara la accion
            {
                Console.Write("{0}->", numero);
            }
        }
    }
}
