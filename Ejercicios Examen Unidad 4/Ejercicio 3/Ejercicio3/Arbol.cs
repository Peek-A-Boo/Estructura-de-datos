using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Arbol
    {
        public Nodo Raiz;

        public Arbol() //Constructor de la clase arbol
        {
            Raiz = null;
        }

        public Nodo Agregar(int numero, string cadena) //Metodo para agregar nodos al arbol
        {
            Nodo Nuevo; //Crea un nodo nuevo
            Nuevo = new Nodo();
            Nuevo.Valor = cadena;
            Nuevo.Numero = numero;
            Nuevo.Izquierda = null;
            Nuevo.Derecha = null; //Le asigna los nuevos valores al nodo

            if (Raiz == null)
            {
                Raiz = new Nodo();
                Raiz.Valor = cadena; //el primer elemento agregado es la raiz
            }
            else
            {
                Nodo Anterior = null;
                Nodo Recorrido = null; //Crea dos nodos mas auxiliares
                Recorrido = Raiz; //Le asigna a uno la raiz
                while (Recorrido != null) //Mientras que el recorrido de todo el arbol no sea nulo
                {
                    Anterior = Recorrido;
                    if (numero < Recorrido.Numero) //Compara ambas cadenas para acomodarlas en el recorrido
                        Recorrido = Recorrido.Izquierda;
                    else
                        Recorrido = Recorrido.Derecha;
                }
                if (numero < Anterior.Numero) //Al acabar de recorrer todo el arbol y llegar a donde debe acomodarse el nodo los vuelve a comparar
                    Anterior.Izquierda = Nuevo; //Para saber de que lado ponerlo
                else
                    Anterior.Derecha = Nuevo;
            }
            return Raiz; //Regresa la raiz
        }

        public void Recorrer(Nodo NodoActual)
        {
            if (NodoActual != null) //Realiza el metodo recursivo mientras el nodo no sea nulo
            {
                Console.WriteLine("({1}) - ({0}) - ({2})", NodoActual.Valor, (NodoActual.Izquierda == null ? "Nodo nulo" : NodoActual.Izquierda.Valor), (NodoActual.Derecha == null ? "Nodo nulo" : NodoActual.Derecha.Valor));
                Recorrer(NodoActual.Izquierda);
                Recorrer(NodoActual.Derecha); //Para imprimir los nodos
            }
        }

        //Metodo para hacer el Postorden
        public void Postorden(Nodo NodoActual)
        {
            if (NodoActual != null) //mientras el nodo actual no sea nulo
            {
                Postorden(NodoActual.Izquierda); //Se recorren los nodos de la izquierda primero para imprimirlos
                Postorden(NodoActual.Derecha); //Se recorren los nodos de la derecha despues para imprimirlos
                Console.Write(" ({0}) ", NodoActual.Valor); //Se imprime la raiz
            }
        }
    }
}
