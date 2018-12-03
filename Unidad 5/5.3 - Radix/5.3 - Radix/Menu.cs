using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3___Radix
{
    class Menu
    {
        public void Iniciar()
        {
            Proceso wea = new Proceso();

            int[] Arreglo1 = new int[10] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 }; //Se crean los 5 arreglos de elementos
            int[] Arreglo2 = new int[9] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            int[] Arreglo3 = new int[8] { 10, 40, 36, 5, 24, 2, 5, 8 };
            int[] Arreglo4 = new int[9] { 55, 42, 0, 3, 0, 1, 2, 4, 7 };
            int[] Arreglo5 = new int[7] { 25, 108, 1024, 12, 351, 251, 39 };

            Console.Write("Elementos del arreglo 1 sin ordenar: \n"); //imprime los elementos del arreglo 1 sin ordenar
            foreach(int elemento in Arreglo1)
            {
                Console.Write("( {0} ) ", elemento);
            }
            Console.Write("\n\nElementos del arreglo 1 ordenados: \n");  //Imprime los elementos del arreglo 1 ordenados
            wea.OrdenamientoRadix(Arreglo1, 10); //Manda el arreglo y su longitud
            Console.ReadLine();

            Console.Write("\n\nElementos del arreglo 2 sin ordenar: \n"); //imprime los elementos del arreglo 2 sin ordenar
            foreach (int elemento in Arreglo2)
            {
                Console.Write("( {0} ) ", elemento);
            }
            Console.Write("\n\nElementos del arreglo 2 ordenados: \n"); //Imprime los elementos del arreglo 2 ordenados
            wea.OrdenamientoRadix(Arreglo2, 9); //Manda el arreglo y su longitud
            Console.ReadLine();

            Console.Write("\n\nElementos del arreglo 3 sin ordenar: \n"); //imprime los elementos del arreglo 3 sin ordenar
            foreach (int elemento in Arreglo3)
            {
                Console.Write("( {0} ) ", elemento);
            }
            Console.Write("\n\nElementos del arreglo 3 ordenados: \n"); //Imprime los elementos del arreglo 3 ordenados
            wea.OrdenamientoRadix(Arreglo3, 8); //Manda el arreglo y su longitud
            Console.ReadLine();

            Console.Write("\n\nElementos del arreglo 4 sin ordenar: \n"); //imprime los elementos del arreglo 4 sin ordenar
            foreach (int elemento in Arreglo4)
            {
                Console.Write("( {0} ) ", elemento);
            }
            Console.Write("\n\nElementos del arreglo 4 ordenados: \n"); //Imprime los elementos del arreglo 4 ordenados
            wea.OrdenamientoRadix(Arreglo4, 9); //Manda el arreglo y su longitud
            Console.ReadLine();

             
            Console.Write("\n\nElementos del arreglo 5 sin ordenar: \n");  //imprime los elementos del arreglo 4 sin ordenar
            foreach (int elemento in Arreglo5)
            {
                Console.Write("( {0} ) ", elemento);
            }
            Console.Write("\n\nElementos del arreglo 5 ordenados: \n"); //Imprime los elementos del arreglo 4 ordenados
            wea.OrdenamientoRadix(Arreglo5, 7); //Manda el arreglo y su longitud
            Console.ReadLine();
        }
    }
}
