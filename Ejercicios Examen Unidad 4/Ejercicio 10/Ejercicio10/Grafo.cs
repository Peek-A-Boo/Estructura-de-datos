using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Grafo
    {
        private int vertices; //variable donde se pone el numero de vertices en el grafo
        private List<int>[] adyacencia; //lista donde se guardan las adyacencias
        List<string> Letras = new List<string>();
        LinkedList<int> Camino1 = new LinkedList<int>();
        LinkedList<int> Camino2 = new LinkedList<int>();
        LinkedList<int> Camino3 = new LinkedList<int>();
        LinkedList<int> Camino4 = new LinkedList<int>();
        private int distancia = 0;
        bool[] visitado;

        public Grafo(int num) //Constructor de la clase grafo donde se inicia el arreglo de lista y el numero de vertices
        {
            LLenarLetras();
            vertices = num;
            visitado = new bool[vertices];
            adyacencia = new List<int>[vertices];
            for (int contador = 0; contador < num; contador++)
            {
                adyacencia[contador] = new List<int>();
            }
            //Camino 1
            Camino1.AddLast(0);
            Camino1.AddLast(1);
            Camino1.AddLast(4);
            Camino1.AddLast(2);
            Camino1.AddLast(1);
            //Camino 2
            Camino2.AddLast(0);
            Camino2.AddLast(3);
            Camino2.AddLast(0);
            Camino2.AddLast(3);
            Camino2.AddLast(0);
            //Camino 3
            Camino3.AddLast(0);
            Camino3.AddLast(3);
            Camino3.AddLast(1);
            Camino3.AddLast(4);
            Camino3.AddLast(0);
            //Camino 4
            Camino4.AddLast(0);
            Camino4.AddLast(1);
            Camino4.AddLast(4);
            Camino4.AddLast(2);
            Camino4.AddLast(1);
            Camino4.AddLast(3);
            Camino4.AddLast(0);
        }

        void LLenarLetras()
        {
            Letras.Add("A");
            Letras.Add("B");
            Letras.Add("C");
            Letras.Add("D");
            Letras.Add("E");
            Letras.Add("F");
            Letras.Add("G");
            Letras.Add("H");
            Letras.Add("I");
        }

        public void AgregarConexion(int vector1, int vector2) //Metodo para crear una conexion direccionada
        {
            adyacencia[vector1].Add(vector2);
        }

        public void reset()
        {
            for (int contador = 0; contador < vertices; contador++) //pone el arreglo de visitado a false
            {
                visitado[contador] = false;
            }

            distancia = 0;
        }

        public void Recorrido1()
        {
            reset();
            foreach (int vert in Camino1)
            {
                if (visitado[vert] == false)
                {
                    visitado[vert] = true;
                    distancia = distancia + 1;
                }
                else
                {
                    visitado[vert] = false;
                    distancia = distancia - 1;
                }
            }
            ComprobarTipo(Camino1, distancia);
        }

        public void Recorrido2()
        {
            reset();
            foreach (int vert in Camino2)
            {
                if (visitado[vert] == false)
                {
                    visitado[vert] = true;
                    distancia = distancia + 1;
                }
                else
                {
                    visitado[vert] = false;
                    distancia = distancia - 1;
                }
            }
            ComprobarTipo(Camino2, distancia);
        }

        public void Recorrido3()
        {
            reset();
            foreach (int vert in Camino3)
            {
                if (visitado[vert] == false)
                {
                    visitado[vert] = true;
                    distancia = distancia + 1;
                }
                else
                {
                    visitado[vert] = false;
                    distancia = distancia - 1;
                }
            }
            ComprobarTipo(Camino3, distancia);
        }

        public void Recorrido4()
        {
            reset();
            foreach (int vert in Camino4)
            {
                if (visitado[vert] == false)
                {
                    visitado[vert] = true;
                    distancia = distancia + 1;
                }
                else
                {
                    visitado[vert] = false;
                    distancia = distancia - 1;
                }
            }
            ComprobarTipo(Camino4, distancia);
        }

        public void ComprobarTipo(LinkedList<int> Nodos, int distanciaRecorrida)
        {
            if (Nodos.First() == Nodos.Last())
            {
                Console.Write("Es un circuito");
            }
            else
            {
                Console.Write("Es un camino simple de {0} de longitud",distanciaRecorrida);
            }
        }
    }
}
