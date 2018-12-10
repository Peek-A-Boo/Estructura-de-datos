using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_2_Busqueda_Binaria
{
    class Busqueda
    {
        int contador = 0;
        public void BuscarBinario(List<string> Palabras, int izquierda, int derecha, string elemento) //Metodo para realizar la busqueda binaria recursiva
        {
            if (contador == 0) //Debido a que la busqueda binaria es para colecciones ordenadas primeramente llamo a la burbuja en la iteracion 1
            {
                BurbujitaBB(ref Palabras);
                contador = 1;
            }

            if (izquierda < derecha) //Si el valor de la izquierda es menor que el de la derecha realizara el siguiente proceso.
            {
                int medio = (izquierda + derecha) / 2; //El elemento medio dentro de la lista
                if (string.Compare(Palabras[medio],elemento)<0) //Si el elemento es mayor que mas de la mitad de la lista
                {
                    BuscarBinario(Palabras, medio + 1, derecha, elemento); //La nueva izquierda se vuelve el medio anterior+1 y se vuelve a llamar
                }
                else if (string.Compare(Palabras[medio], elemento) > 0) //Si el elemento es mneor que mas de la mitad de la lista
                {
                    BuscarBinario(Palabras, izquierda, medio - 1, elemento); //La nueva derecha se vuelve el medio anterior-1 y se vuelve a llamar
                }
                else //Si se encuentra el elemento
                {
                    Console.Write("\n\nElemento {0} encontrado en la posicion {1}\n\n", Palabras[medio], medio + 1); //Se escribe el mensaje de encontrado
                    ImprimirLista(Palabras); //Imprime la lista de numeros
                }
            }
            else
            {
                Console.Write("Elemento inexistente dentro de la lista");  //Si no lo encuentra en ninguna iteracion significa que no existe
                ImprimirLista(Palabras); //Imprime la lista de numeros
            }
            Console.ReadLine();
        }

        private void BurbujitaBB(ref List<string> Palabritas) //Metodo donde se realiza el metodo de la burbuja
        {
            string tempy = "";
            for (int contador1 = 0; contador1 < Palabritas.Count(); contador1++) //Primer ciclo donde se hace cuantas veces se repetira el otro for
            {
                for (int contador2 = 1; contador2 < Palabritas.Count(); contador2++) //Segundo ciclo donde se hacen las comparaciones
                {
                    if (string.Compare(Palabritas[contador2],Palabritas[contador2 - 1])<0) //Si el elemento con indice mayor es menor se invierten
                    {
                        tempy = Palabritas[contador2]; //Variable temporal para guardar el numero que vamos a reemplazar
                        Palabritas[contador2] = Palabritas[contador2 - 1]; //Se asigna el valor al indice mayor el del indice anterior
                        Palabritas[contador2 - 1] = tempy; //Guarda el elemento previamente cambiado;
                    }
                }
            }
        }

        private void ImprimirLista(List<string> Palabras) //Metodo para imprimir la lista
        {
            foreach (string palabra in Palabras) //Por cada elemento del tipo int dentro de la lista realizara la accion
            {
                Console.Write("{0}->", palabra);
            }
        }
    }
}
