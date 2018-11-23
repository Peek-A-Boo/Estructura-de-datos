using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Menu
    {
        public void RealizarOperacion()
        {
            //Crea el arbol usado para la operacion
            Arbol Arbolito = new Arbol();

            //Inserta el primer nodo que es la raiz
            Arbolito.InsertarNodo(1, 0, "Raiz", 1);
            //Inserta los nodos en el nivel 2 y los conecta con su padre
            Arbolito.InsertarNodo(2, 1, "0", 2);
            Arbolito.InsertarNodo(3, 1, "1", 2);
            //Inserta los nodos en el nivel 3 y los conecta con su padre
            Arbolito.InsertarNodo(4, 2, "0", 3);
            Arbolito.InsertarNodo(5, 2, "I", 3);
            Arbolito.InsertarNodo(8, 3, "1", 3);
            //Inserta los nodos en el nivel 4 y los conecta con su padre
            Arbolito.InsertarNodo(6, 4, "A", 4);
            Arbolito.InsertarNodo(7, 4, "E", 4);
            Arbolito.InsertarNodo(9, 8, "0", 4);
            Arbolito.InsertarNodo(10, 8, "1", 4);
            //Inserta los nodos en el nivel 5 y los conecta con su padre
            Arbolito.InsertarNodo(11, 9, "K", 5);
            Arbolito.InsertarNodo(12, 9, "O", 5);
            Arbolito.InsertarNodo(13, 10, "1", 5);
            //Inserta los nodos en el nivel 6 y los conecta con su padre
            Arbolito.InsertarNodo(14, 13, "P", 6);
            Arbolito.InsertarNodo(15, 13, "U", 6);

            //Para imprimir las rutas
            Console.Write("Ruta al elemento A: ");
            Arbolito.ImprimirRuta(Arbolito.raiz, Arbolito, 6, Arbolito.raiz);
            Console.Write("\n\nRuta al elemento E: ");
            Arbolito.ImprimirRuta(Arbolito.raiz, Arbolito, 7, Arbolito.raiz);
            Console.Write("\n\nRuta al elemento I: ");
            Arbolito.ImprimirRuta(Arbolito.raiz, Arbolito, 5, Arbolito.raiz);
            Console.Write("\n\nRuta al elemento K: ");
            Arbolito.ImprimirRuta(Arbolito.raiz, Arbolito, 11, Arbolito.raiz);
            Console.Write("\n\nRuta al elemento O: ");
            Arbolito.ImprimirRuta(Arbolito.raiz, Arbolito, 12, Arbolito.raiz);
            Console.Write("\n\nRuta al elemento P: ");
            Arbolito.ImprimirRuta(Arbolito.raiz, Arbolito, 14, Arbolito.raiz);
            Console.Write("\n\nRuta al elemento U: ");
            Arbolito.ImprimirRuta(Arbolito.raiz, Arbolito, 15, Arbolito.raiz);
            Console.ReadLine();
        }
    }
}
