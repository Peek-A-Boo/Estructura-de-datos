using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_2
{
    class Menu
    {
        Random azar = new Random();//Crea los objetos, listas y variables para el programa
        List<int> Numeros = new List<int>();
        int numero = 0;
        Radix Proceso = new Radix();

        private int GenerarNumero() //Metodo para generar numeros al azar del 0 al 100
        {
            return azar.Next(0,101);
        }

        private void LLenarLista() //Metodo recursivo para llenar la lista
        {
            if(Numeros.Count<80)
            {
                numero = GenerarNumero();
                if (Numeros.Contains(numero) == false) //Si el numero no se repite lo ingresa a la lista y si no, vuelve a llamar el metodo
                {
                    Numeros.Add(numero);
                    LLenarLista();
                }
                else
                    LLenarLista();
            }
        }

        private void ImprimirLista()
        {
            int contador = 1;
            //Imprime la lista desordenado
            Console.Write("Lista no ordenada: \n");
            foreach (int numero in Numeros)
            {
                Console.WriteLine("{0} .- {1}",contador, numero);
                contador++;
            }
            Proceso.OrdenamientoRadix(Numeros); //Ordena la lista con el metodo radix
            contador = 1;
            //Imprime la lista ordenada
            Console.Write("\n\nLista no ordenada: \n");
            foreach (int numero in Numeros)
            {
                Console.WriteLine("{0} .- {1}", contador, numero);
                contador++;
            }
            Console.ReadLine();
        }

        public void Iniciar() //Metodo para iniciar el programa
        {
            LLenarLista(); //Llena la lista e imprime la lista.
            ImprimirLista();
        }
    }
}
