using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Arbol2
    {
        public void RealizarOperacion()
        {
            Arboles Arbol = new Arboles();


            Arbol.InsertarNodo(5, 0, "E", 1);

            Arbol.InsertarNodo(4, 5, "D", 2);
            Arbol.InsertarNodo(6, 5, "F", 2);
            Arbol.InsertarNodo(1, 5, "A", 2);
            Arbol.InsertarNodo(7, 5, "G", 2);

            Arbol.InsertarNodo(2, 1, "B", 3);

            Arbol.InsertarNodo(3, 2, "C", 4);

            Console.WriteLine("El numero de nodos es de: " + (Arbol.ObtenerTamaño(Arbol.raiz, Arbol)));
            Console.WriteLine("La altura es de: " + Arbol.ObtenerAltura(Arbol.raiz, Arbol));
            Console.WriteLine("El numero de niveles es de: " + Arbol.ObtenerNiveles(Arbol.raiz, Arbol));
            Console.ReadLine();
            Arbol.ImprimirArbol(Arbol.raiz, Arbol);
            Console.ReadLine();
            Console.Write("Ruta al elemento mas largo: E -> A -> B -> C");
        }
    }
}
