using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Arbol1
    {
        public void RealizarOperacion()
        {
            Arboles Arbol = new Arboles();

            Arbol.InsertarNodo(1, 0, "A", 1);

            Arbol.InsertarNodo(2, 1, "B", 2);
            Arbol.InsertarNodo(3, 1, "C", 2);
            Arbol.InsertarNodo(5, 1, "E", 2);
            Arbol.InsertarNodo(4, 1, "D", 2);

            Arbol.InsertarNodo(6, 5, "F", 3);

            Console.WriteLine("El numero de nodos es de: " + (Arbol.ObtenerTamaño(Arbol.raiz, Arbol)));
            Console.WriteLine("La altura es de: " + Arbol.ObtenerAltura(Arbol.raiz, Arbol));
            Console.WriteLine("El numero de niveles es de: " + Arbol.ObtenerNiveles(Arbol.raiz, Arbol));
            Console.ReadLine();
            Arbol.ImprimirArbol(Arbol.raiz, Arbol);
            Console.ReadLine();
            Console.Write("Ruta al elemento mas largo: G -> A -> C");
            Console.ReadLine();
        }
    }
}
