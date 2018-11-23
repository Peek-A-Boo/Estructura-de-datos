using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9
{
    class Grafo
    {
        private int vertices; //variable donde se pone el numero de vertices en el grafo
        private List<int>[] adyacencia; //lista donde se guardan las adyacencias
        List<string> Letras = new List<string>();


        public Grafo(int num) //Constructor de la clase grafo donde se inicia el arreglo de lista y el numero de vertices
        {
            LLenarLetras();
            vertices = num;
            adyacencia = new List<int>[vertices];
            for(int contador=0;contador<num;contador++)
            {
                adyacencia[contador] = new List<int>();
            }
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

        Grafo ObtenerReverso() //Metodo para obtener la raiz al reves(Necesaria dentro del algoritmo para conseguir los elementos conexos)
        {
            Grafo GraffZeppelin = new Grafo(vertices);
            for (int contadorVectores = 0;contadorVectores<vertices;contadorVectores++) 
            {
                foreach(int wea in adyacencia[contadorVectores]) //Por cada objeto dentro de la lista de adyacencia
                {
                    GraffZeppelin.AgregarConexion(wea, contadorVectores); //Agrega la conexion pero esta vez al reves
                }
            }
            return GraffZeppelin; //regresa el grafo al reves
        } 

        void ImprimirEnProfundidad(int vertice, bool[] visitado) //metodo para imprimir en profundidad
        {
            visitado[vertice] = true;
            Console.Write(Letras[vertice] + " ");

            foreach (int wea in adyacencia[vertice]) //Por cada elemento en la lista de adyacencia
            {
                if (visitado[wea] == false) //Si aun no lo visita lo imprime y lo manda al metodo recursivo
                {
                    ImprimirEnProfundidad(wea, visitado);
                } 
            }
        }

        void LlenaOrdenado(int vertice, bool[] visitado, Stack<int> wea) //Metodo para llenar la pila 
        {
            visitado[vertice] = true;

            foreach(int weaita in adyacencia[vertice]) 
            {
                if (visitado[weaita]==false)
                {
                    LlenaOrdenado(weaita, visitado, wea); //Si no lo ha visitado llama al metodo recursivo
                }
            }

            wea.Push(vertice); //Agrega el vertice a la lista
        }

        public void ImprimirWeasConectadas() //Metodo para imprimir los metodos fuertemente conexos
        {
            Stack<int> pila = new Stack<int>(); //pila donde se guardan los elementos

            bool[] visitado = new bool[vertices];

            for(int contador =0; contador<vertices;contador++) //pone el arreglo de visitado a false
            {
                visitado[contador] = false;
            }

            for (int contador=0;contador<vertices;contador++)
            {
                if (visitado[contador]==false)
                {
                    LlenaOrdenado(contador, visitado, pila); //Si no ha visitado el vertice en cuestion se llama para que llene la pila donde se almacenan los vertices
                }
            }

            Grafo Giraffe = ObtenerReverso(); //Obtiene el grafo en reversa

            for (int contador =0; contador<vertices;contador++) 
            {
                visitado[contador] = false; //Pone el visitado en false
            }

            while(pila.Count>0) //Mientras que la pila tenga mas que 0 elementos
            {
                int weada = pila.Pop(); //Hace pop a un elemento dentro de la pila

                if (visitado[weada] == false) //Si el visitado es falso
                {
                    Giraffe.ImprimirEnProfundidad(weada, visitado); //Imprime en profundidad
                    Console.WriteLine(); //writeline para poner las diferentes conexiones separadas(si hay mas de uno en una linea es porque esta conexo)
                }
            }
        }
    }
}
