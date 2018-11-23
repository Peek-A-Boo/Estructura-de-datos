using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Menu
    {
        public void Iniciar()
        {
            //Inicializar el bojeto de clase arbol 
            Arbol Arbolito = new Arbol();
            Arbolito.Agregar("El");
            //Ingresa los datos del arbol
            Arbolito.Agregar("Rapido");
            Arbolito.Agregar("Zorro");
            Arbolito.Agregar("Marron");
            Arbolito.Agregar("Salta");
            Arbolito.Agregar("Sobre");
            Arbolito.Agregar("El");
            Arbolito.Agregar("Perro");
            Arbolito.Agregar("Perezoso");
            //Imprime el arbol
            Console.Write("\t<----Arbol---->\n");
            Arbolito.Recorrer(Arbolito.Raiz);

            Console.ReadKey();
        }
    }
}
