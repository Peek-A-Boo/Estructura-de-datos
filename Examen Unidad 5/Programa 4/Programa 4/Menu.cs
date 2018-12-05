using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_4
{
    class Menu
    {
        List<string> Palabras = new List<string>();
        Proceso QuickSort = new Proceso();

        private void LLenarLista() //metodo para llenar la lista con la oracion
        {
            string oracion = "Lorem ipsum dolor sit amet consectetur adipiscing elit Fusce varius augue vitae tincidunt viverra sem felis bibendum nisl id cursus diam leo sit amet urna Duis ac massa est";
            foreach(string palabra in oracion.Split(' ')) //Separa la lista en un arreglo en cada espacio
            {
                Palabras.Add(palabra); //Agrega cada palabra a una lista
            }
        }

        private void ImprimirLista()
        {
            int contador = 1;
            //Imprime la lista desordenado
            Console.Write("Lista no ordenada: \n");
            foreach (string palabra in Palabras)
            {
                Console.WriteLine("{0} .- {1}", contador, palabra);
                contador++;
            }
            QuickSort.Ordenar(Palabras,0,Palabras.Count-1); //Ordena la lista con quicksort
            contador = 1;
            //Imprime la lista ordenada
            Console.Write("\n\nLista ordenada: \n");
            foreach (string palabra in Palabras)
            {
                Console.WriteLine("{0} .- {1}", contador, palabra);
                contador++;
            }
            Console.ReadLine();
        }

        public void Iniciar() //Metodo para iniciar el programa, llena la lista y la imprime.
        {
            LLenarLista();
            ImprimirLista();
        }
    }
}
