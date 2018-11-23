using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Menu
    {
        public void Iniciar()
        {
            //Inicializar el bojeto de clase arbol 
            Arbol Arbolito = new Arbol();
            Arbolito.Agregar("Enología");
            //Ingresa los datos del arbol
            Arbolito.Agregar("Frenología");
            Arbolito.Agregar("Campanología");
            Arbolito.Agregar("Ornitología");
            Arbolito.Agregar("Ictiología");
            Arbolito.Agregar("Limnología");
            Arbolito.Agregar("Alquimia");
            Arbolito.Agregar("Astrología");
            //Imprime el arbol
            Console.Write("\t<----Arbol---->\n");
            Arbolito.Recorrer(Arbolito.Raiz);

            Console.ReadKey();
        }
    }
}
