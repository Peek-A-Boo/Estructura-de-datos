using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3_Grafos
{
    class Grafo
    {
        int[,] Vertices = new int[7, 7]; //Matriz de adyacencia
        List<string> Letras = new List<string>(); //Lista donde se guardan las letras, es como un diccionario para traducir de numeros a letras
        
        public Grafo()
        {
            LlenarMatriz();
        }

        private void LlenarMatriz()
        {
            Letras.Add("A"); //Agrega las 7 letras del programa
            Letras.Add("B");
            Letras.Add("C");
            Letras.Add("D");
            Letras.Add("E");
            Letras.Add("F");
            Letras.Add("G");
            for (int contador1 = 0; contador1 < 7; contador1++)
            {
                for (int contador2 = 0; contador2 < 7; contador2++)
                {
                    Vertices[contador1, contador2] = 0; //LLena la matriz de adyacencia con puros 0
                }
            }
            CrearConexiones("A", "A");
            CrearConexiones("A", "B");
            CrearConexiones("B", "C");
            CrearConexiones("B", "G"); //Crea las conexiones entre los diferentes vertices
            CrearConexiones("C", "D");
            CrearConexiones("C", "G");
            CrearConexiones("D", "E");
            CrearConexiones("D", "F");
            CrearConexiones("E", "F");
            CrearConexiones("F", "G");
        }

        private void CrearConexiones(string vertice1,string vertice2)
        {
            Vertices[Letras.IndexOf(vertice1), Letras.IndexOf(vertice2)] = 1;
            Vertices[Letras.IndexOf(vertice2), Letras.IndexOf(vertice1)] = 1; //Metodo para traducir las letras a numeros y llenar la matriz dependiendo 
        }                                                                       //los parametros

        public void RecorrerAnchura() //Metodo para recorrer en anchura el grafo
        {
            string recorrido = ""; //Cadena donde se guarda la ruta
            for (int contador1 = 0; contador1 < 7; contador1++)
            {

                if (recorrido.Contains(Letras[contador1]) == false)
                {
                    recorrido = recorrido + Letras[contador1] + "-> "; //Agrega el recorrido
                }

                for (int contador2 = 0; contador2 < 7 ; contador2++)
                {
                    if (Vertices[contador1,contador2]==1)
                    {
                        if (recorrido.Contains(Letras[contador2])==false)
                        {
                            recorrido = recorrido + Letras[contador2] + "-> "; //Agrega el recorrido
                        }
                    }
                }
            }
            Console.Write("Recorrido en anchura: {0}", recorrido); //Despliega el recorrido
        }

        public void RecorrerProfundidad() //Metodo para recorrer en anchura el grafo
        {
            string recorrido = ""; //Cadena donde se guarda la ruta
            for (int contador1 = 0; contador1 < 7; contador1++)
            {
                for (int contador2 = 0; contador2 < 7; contador2++)
                {
                    if (Vertices[contador1, contador2] == 1)
                    {
                        if (recorrido.Contains(Letras[contador2]) == false)
                        {
                            recorrido = recorrido + Letras[contador2] + "-> "; //Agrega el recorrido
                        }
                    }
                }
            }
            Console.Write("Recorrido en profundidad: {0}", recorrido);//Despliega el recorrido
        }
    }
}
