using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Arbol
    {
        public Nodo raiz; //Nodo raiz
        private LinkedList<string> Ruta = new LinkedList<string>();

        public Arbol()
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

        public void ObtenerRuta(Nodo Nodin, Arbol Arbolin, int valor, Nodo Temporal) //Metodo recursivo para hacer la ruta a un nodo en especifico
        {
            if (Nodin != null)              //Ingreso dos veces la raiz debido a que la raiz sera necesario para que se pueda volver a recorrer el arbol
            {                               //Debido a como funciona el metodo recursivo
                foreach (Nodo wea in Nodin.Hijos)
                {
                    if (valor == wea.Valor)     //Cuando se encuentra el nodo que tiene el valor buscado
                    {
                        Ruta.AddFirst(wea.Letra);       //Se agrega la letra a la lista
                        ObtenerRuta(Temporal, Arbolin, Nodin.Valor, Temporal); //Vuelve a llamar el metodo pero desde el inicio otra vez y esta vez la letra buscada
                    }                                                           //Es la del nodo que tenia de hijo al nodo buscado
                    else
                    {
                        ObtenerRuta(wea, Arbolin, valor, Temporal); //Vuelve a llamar el metodo si no es la misma letra
                    }
                }
            }
        }

        public void ImprimirRuta(Nodo Nodin, Arbol Arbolin, int valor, Nodo Temporal)
        {
            ObtenerRuta(Nodin, Arbolin, valor, Temporal); //Obtiene la ruta
            foreach (string wea in Ruta)
            {
                Console.Write("{0} -> ", wea);      //Despliega la lista que tiene la ruta al nodo en cuestion
            }
            Console.Write(" Finalizado ");
            Ruta.Clear();
        }
    }
}
