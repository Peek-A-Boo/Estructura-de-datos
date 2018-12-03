using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1___Busqueda_Secuencial
{
    class Menu
    {
        public void Iniciar()
        {
            int[] Numeros1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //Se crean e inicializan ambos arreglos de numeros
            int[] Numeros2 = new int[10] { 50, 23, 30, 40, 10, 33, 66, 33, 0, 7 };

            Busqueda objeto = new Busqueda(); //Se crea el objeto que tiene la busqueda secuencial

            Console.Write("Elementos en el arreglo 1: \n"); //Imprime los elementos dentro de los arreglos
            foreach(int elemento in Numeros1)
            {
                Console.Write("{0} - ", elemento);
            }
            Console.Write("\nElementos en el arreglo 2: \n");
            foreach (int elemento in Numeros2)
            {
                Console.Write("{0} - ", elemento);
            }
            Console.Write("\n\n\nBusqueda de 5 en el arreglo 1: \n"); //Busca el numero 5 dentro de los arreglos
            objeto.Buscar(Numeros1, 5);
            Console.Write("\nBusqueda de 33 en el arreglo 2: \n");  //Busca el numero 33 dentro de los arreglos
            objeto.Buscar(Numeros2, 33);
            Console.ReadLine();
        }
    }
}
