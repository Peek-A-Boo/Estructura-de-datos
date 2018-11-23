using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Menu
    {
        //crea los 3 grafos
        Grafo Graff = new Grafo(5);

        public Menu()
        {
            LlenarGrafos();
        }

        void LlenarGrafos()
        {
            //Grafo
            Graff.AgregarConexion(0, 1);
            Graff.AgregarConexion(0, 3);
            Graff.AgregarConexion(1, 0);
            Graff.AgregarConexion(1, 4);
            Graff.AgregarConexion(2, 1);
            Graff.AgregarConexion(4, 2);
            Graff.AgregarConexion(4, 3);
            Graff.AgregarConexion(3, 0);
        }

        public void Iniciar()
        {
            Console.Write("Camino 1: ");
            Graff.Recorrido1();
            Console.ReadLine();
            Console.Write("Camino 2: ");
            Graff.Recorrido2();
            Console.ReadLine();
            Console.Write("Camino 3: ");
            Graff.Recorrido3();
            Console.ReadLine();
            Console.Write("Camino 4: ");
            Graff.Recorrido4();
            Console.ReadLine();
        }
    }
}
