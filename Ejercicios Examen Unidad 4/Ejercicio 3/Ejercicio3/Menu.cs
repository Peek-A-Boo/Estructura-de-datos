using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Menu
    {
        public void Iniciar()
        {
            //Inicializar el objeto de clase arbol (Para el primer arbol)
            Arbol Arbolito = new Arbol();
            Arbolito.Agregar(10, "A");
            //Ingresa los datos del arbol 1
            Arbolito.Agregar(15, "C");
            Arbolito.Agregar(12, "E");
            Arbolito.Agregar(14, "D");
            Arbolito.Agregar(25, "G");
            Arbolito.Agregar(22, "F");
            Arbolito.Agregar(21, "B");
            Arbolito.Agregar(23, "I");
            Arbolito.Agregar(24, "H");
            Arbolito.Agregar(30, "K");
            Arbolito.Agregar(40, "J");
            //Imprime el arbol
            Console.Write("\t<----Arbol---->\n");
            Arbolito.Recorrer(Arbolito.Raiz);
            Console.Write("\n\nPostorden: ");
            Arbolito.Postorden(Arbolito.Raiz);
            Console.ReadLine();
        }
    }
}
