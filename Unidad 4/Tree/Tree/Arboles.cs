using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Arboles
    {
        public Nodo raiz; //Nodo raiz
        private List<string> Ruta = new List<string>();
        public Arboles()
        {
            raiz = null; //Al iniciar el arbol la raiz empieza nula
        }

        public Nodo BuscarRecursivo(int dato, string letra)  //Metodo recursivo para buscar un nodo en especial
        {
            return (BuscarRecursivo(raiz, dato, letra)); 
        }

        Nodo Resultado = null;
        private Nodo BuscarRecursivo(Nodo Nodin, int valorBuscado, string letra) //Metodo recursivo para buscar un nodo en especifico
        {

            if (Nodin == null)  
            {
                Resultado = null;
            }

            if (valorBuscado == Nodin.Valor) //Si el valor buscado es el mismo que el nodo obtenido entonces ese es el nodo que se esta buscando
            {
                Resultado = Nodin;
            }

            foreach (Nodo wea in Nodin.Hijos) //Compara todos los nodos hijos dentro de un padre.
            {
                BuscarRecursivo(wea, valorBuscado, letra);
            }

            return Resultado;       //Regresa el resultado obtenido.
        }

        //Metodo recursivo para insertar nodos, el primer nodo insertado es la raiz
        public void InsertarNodo(int valor, int padre, string letra, int contador)
        {
            raiz = InsertarNodo(raiz, valor, padre, letra, contador);

        }
        //Metodo recursivo para insertar nodo ya sea como raiz o hijo de un nodo
        private Nodo InsertarNodo(Nodo Nodin, int valor, int padre, string letra, int contador)
        {
            //Si el nodo esta nulo crea uno nuevo (este sera la raiz)
            if (Nodin == null)
            {
                Nodin = new Nodo(valor, letra, contador);
            }

            //Si no esta nulo/vacio
            else
            {
                Nodo NodoPadre = BuscarRecursivo(padre, letra); //Busca el nodo que lo tenga como hijo
                if (NodoPadre != null)                           //Si dicho nodo tiene padre lo agrega a los nodos que tiene ese padre
                {

                    NodoPadre.Hijos.Add(new Nodo(valor, letra, contador)); //lo mete a la lista de hijos que tiene el padre.
                }
                else
                {
                    Nodin.Hijos.Add(new Nodo(valor, letra, contador)); //Si no tiene tiene un padre lo agrega como un nodo independiente.
                }
            }

            return Nodin; //regresa el nodo.
        }

        int tamaño = 0; //Obtiene el tamaño del arbol (Numero de nodos)
        public int ObtenerTamaño(Nodo Nodin, Arboles arbolin)
        {
            if (Nodin != null)    //si el nodo no esta nulo entra al metodo recursivo para conseguir el tamaño
            {
                tamaño++; //Aumenta el tamaño en uno
                foreach (Nodo wea in Nodin.Hijos) //Por cada nodo dentro de la lista de hijos de un nodo
                {
                    ObtenerTamaño(wea, arbolin); //Llamara al metodo otra vez, sumando el tamaño en uno y esta vez sera con un nodo dentro
                }                                //de la lista de hijos.
            }
            return tamaño; //Regresa el tamaño del arbol.
        }

        int altura = 2; //Obtiene la altura del arbol, empieza en dos porque la altura solo la sumo si un nodo tiene hijos
        public int ObtenerAltura(Nodo Nodin, Arboles arbolin) //Y como no cuenta el nodo inicial debido a como funciona el metodo 
        {                                                     //Ademas de que no suma si el nodo no tiene hijos
            if (Nodin != null)
            {
                foreach (Nodo wea in Nodin.Hijos)            //Por cada nodo dentro de una lista reliza el proceso recursivo
                {
                    if (wea.Hijos.Count > 0)                  //Si la lista de hijos tiene mas de 0 entonces se le suma la altura uno
                    {
                        altura++;
                    }
                    ObtenerAltura(wea, arbolin);            //Se vuelve a llamar el metodo para hacerlo recursivo que termina hasta que un nodo
                }                                           //esta vacio
            }
            return altura;  //Regresa la altura.
        }

        int niveles = 2;  //Obtiene el nivel del arbol, empieza en dos porque el nivel solo la sumo si un nodo tiene hijos
        public int ObtenerNiveles(Nodo Nodin, Arboles arbolin) //Y como no cuenta el nodo inicial (raiz) debido a como funciona el metodo 
        {                                                       //Ademas de que no suma si el nodo no tiene hijos
            if (Nodin != null)
            {
                foreach (Nodo wea in Nodin.Hijos)           //Por cada nodo dentro de una lista reliza el proceso recursivo
                {
                    if (wea.Hijos.Count > 0)                //Si la lista de hijos tiene mas de 0 entonces se le suma el nivel en uno
                    {
                        niveles++;
                    }
                    ObtenerNiveles(wea, arbolin);       //Se vuelve a llamar el metodo para hacerlo recursivo que termina hasta que un nodo
                }                                           //esta vacio
            }
            return niveles; //Regresa el nivel del arbol.
        }

        public void ImprimirArbol(Nodo Nodin, Arboles Arbolin) //Metodo recursivo para imprimir el arbol basado en el de altura y niveles
        {
            Console.WriteLine("Nivel {0}: {1}", Nodin.Nivel, Nodin.Letra);  //Imprime el nivel y la letra
            ImprimirArbol(Nodin, Arbolin, 1);                               //LLama al metodo sobrecargado para hacerlo recursivo
        }

        public void ImprimirArbol(Nodo Nodin, Arboles Arbolin, int prueba) //Metodo recursivo para imprimir el arbol basado en el de altura y niveles
        {
            if (Nodin != null)                    //Si el nodo no esta vacio.
            {
                foreach (Nodo wea in Nodin.Hijos)       //Por cada nodo en la lista de hijos de un nodo
                {
                    Console.WriteLine("Nivel {0}: {1}", wea.Nivel, wea.Letra);  //Imprime la letra y el nivel del nodo
                    ImprimirArbol(wea, Arbolin, 1); //Vuelve a llamar el metodo
                }
            }
        }

        /*public void ObtenerRuta(Nodo Nodin, Arboles Arbolin, string letra,Nodo Temporal)
        {
            Ruta.Add(Nodin.Letra);
            ObtenerRuta(Nodin, Arbolin, letra, Temporal);
        }

        public void ObtenerRuta(Nodo Nodin, Arboles Arbolin,string letra, int prueba, Nodo Temporal)
        {
            if (Nodin!=null)
            {
                foreach (Nodo wea in Nodin.Hijos)
                {
                    if(letra==wea.Letra)
                    {
                        Ruta.Add(wea.Letra);
                        ObtenerRuta(wea, Arbolin,Nodin.Letra,1,Temporal); //Vuelve a llamar el metodo
                    }
                    else
                    {
                        ObtenerRuta(wea, Arbolin, letra, 1,Temporal); //Vuelve a llamar el metodo
                    }
                }
            }
        }
        */

        /*public void ImprimirRuta(Nodo Nodin, Arboles Arbolin, string letra, Nodo Temporal)
        {
            ObtenerRuta(Nodin, Arbolin, letra,Temporal);
            foreach (string wea in Ruta)
            {
                Console.WriteLine(wea);
            }
        }
        */

    }
}
