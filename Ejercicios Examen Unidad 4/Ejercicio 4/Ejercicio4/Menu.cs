using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Menu
    {
        public void Iniciar()
        {
            //Inicializar el bojeto de clase arbol 
            Arbol Arbolito = new Arbol();
            Arbolito.Agregar("Banana");
            //Ingresa los datos del arbol
            Arbolito.Agregar("Melocoton");
            Arbolito.Agregar("Manzana");
            Arbolito.Agregar("Pera");
            Arbolito.Agregar("Coco");
            Arbolito.Agregar("Mango");
            Arbolito.Agregar("Papaya");
            //Imprime el arbol
            Console.Write("\t<----Arbol---->\n");
            Arbolito.Recorrer(Arbolito.Raiz);

            Console.ReadKey();
        }
    }
}
