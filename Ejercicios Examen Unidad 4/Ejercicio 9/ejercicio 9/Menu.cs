using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9
{
    class Menu
    {
        //crea los 3 grafos
        Grafo Graff1 = new Grafo(5);
        Grafo Graff2 = new Grafo(6);
        Grafo Graff3 = new Grafo(9);

        public Menu()
        {
            LlenarGrafos();
        }

        void LlenarGrafos()
        { 
            //Grafo1
            Graff1.AgregarConexion(0, 4);
            Graff1.AgregarConexion(4, 1);
            Graff1.AgregarConexion(1, 0);
            Graff1.AgregarConexion(1, 2);
            Graff1.AgregarConexion(3, 4);
            Graff1.AgregarConexion(3, 1);
            Graff1.AgregarConexion(3, 2);

            //Grafo2
            Graff2.AgregarConexion(0, 5);
            Graff2.AgregarConexion(1, 0);
            Graff2.AgregarConexion(2, 1);
            Graff2.AgregarConexion(2, 3);
            Graff2.AgregarConexion(3, 4);
            Graff2.AgregarConexion(4, 2);
            Graff2.AgregarConexion(4, 5);

            //Grafo3
            Graff3.AgregarConexion(0, 8);
            Graff3.AgregarConexion(0, 2);
            Graff3.AgregarConexion(1, 0);
            Graff3.AgregarConexion(1, 7);
            Graff3.AgregarConexion(1, 2);
            Graff3.AgregarConexion(3, 2);
            Graff3.AgregarConexion(3, 4);
            Graff3.AgregarConexion(3, 1);
            Graff3.AgregarConexion(4, 3);
            Graff3.AgregarConexion(5, 3);
            Graff3.AgregarConexion(5, 6);
            Graff3.AgregarConexion(5, 4);
            Graff3.AgregarConexion(6, 2);
            Graff3.AgregarConexion(6, 3);
            Graff3.AgregarConexion(7, 5);
            Graff3.AgregarConexion(7, 6);
            Graff3.AgregarConexion(7, 8);
            Graff3.AgregarConexion(8, 0);
            Graff3.AgregarConexion(8, 6);
        }

        public void Iniciar()
        {
            Console.Write("Elementos fuertemente conexos del grafo 1: \n");
            Graff1.ImprimirWeasConectadas();
            Console.ReadLine();
            Console.Write("Elementos fuertemente conexos del grafo 2: \n");
            Graff2.ImprimirWeasConectadas();
            Console.ReadLine();
            Console.Write("Elementos fuertemente conexos del grafo 3: \n");
            Graff3.ImprimirWeasConectadas();
            Console.ReadLine();
        }
    }
}
