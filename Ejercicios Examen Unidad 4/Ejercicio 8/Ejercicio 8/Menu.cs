using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Menu
    {
        public void Iniciar()
        {
            //Inicializar el objeto de clase arbol (Para el primer arbol)
            Arbol Arbolito1 = new Arbol();
            Arbolito1.Agregar(-1);
            //Ingresa los datos del arbol 1
            Arbolito1.Agregar(0);
            Arbolito1.Agregar(2);
            Arbolito1.Agregar(-2);
            Arbolito1.Agregar(3);
            Arbolito1.Agregar(6);
            Arbolito1.Agregar(-3);
            Arbolito1.Agregar(5);
            Arbolito1.Agregar(1);
            Arbolito1.Agregar(4);
            //Imprime el arbol
            Console.Write("\t<----Arbol 1---->\n");
            Arbolito1.Inorden(Arbolito1.Raiz);
            Console.ReadLine();

            //Ingresa los datos del arbol 2
            //Inicializar el objeto de clase arbol (Para el segundo arbol)
            Arbol Arbolito2 = new Arbol();
            Arbolito2.Agregar(-1);
            //Ingresa los datos del arbol 1
            Arbolito2.Agregar(7);
            Arbolito2.Agregar(4);
            Arbolito2.Agregar(11);
            Arbolito2.Agregar(5);
            Arbolito2.Agregar(-8);
            Arbolito2.Agregar(15);
            Arbolito2.Agregar(-3);
            Arbolito2.Agregar(-2);
            Arbolito2.Agregar(6);
            Arbolito2.Agregar(10);
            Arbolito2.Agregar(3);
            //Imprime el arbol
            Console.Write("\t<----Arbol 2---->\n");
            Arbolito2.Inorden(Arbolito2.Raiz);
            Console.ReadLine();
        }
    }
}
