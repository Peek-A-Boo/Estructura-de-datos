using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Arbol3
    {
        public void RealizarOperacion()
        {
            Arboles Arbol = new Arboles();

            Arbol.InsertarNodo(11, 0, "K", 1);

            Arbol.InsertarNodo(2, 11, "B", 2);
            Arbol.InsertarNodo(1, 11, "A", 2);
            Arbol.InsertarNodo(3, 11, "C", 2);
            Arbol.InsertarNodo(4, 11, "D", 2);

            Arbol.InsertarNodo(9, 4, "I", 3);
            Arbol.InsertarNodo(5, 4, "E", 3);

            Arbol.InsertarNodo(6, 5, "F", 4);
            Arbol.InsertarNodo(7, 5, "G", 4);
            Arbol.InsertarNodo(10, 9, "J", 4);

            Arbol.InsertarNodo(8, 7, "H", 5);


            Console.WriteLine("El numero de nodos es de: " + (Arbol.ObtenerTamaño(Arbol.raiz, Arbol)));
            Console.WriteLine("La altura es de: " + Arbol.ObtenerAltura(Arbol.raiz, Arbol));
            Console.WriteLine("El numero de niveles es de: " + Arbol.ObtenerNiveles(Arbol.raiz, Arbol));
            Console.ReadLine();
            Arbol.ImprimirArbol(Arbol.raiz, Arbol);
            Console.ReadLine();
            Console.WriteLine("Ruta al elemento C: K -> C");
            Console.ReadLine();
            Console.Write("Ruta al elemento H: K -> D - > E -> G -> H ");
            Console.ReadLine();
            Console.WriteLine("Ruta al elemento J: K -> D -> I -> J");
            Console.ReadLine();
        }
    }
}
