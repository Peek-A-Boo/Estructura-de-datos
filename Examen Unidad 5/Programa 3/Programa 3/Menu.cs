using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_3
{
    class Menu
    {
        double numero = 0;
        string opcion = "Y";
        List<double> Numeros = new List<double>();
        Proceso Shell = new Proceso(); //Se crean las variables, objetos y listas que se ocuparan para el programa.

        private void LlenarLista()  //Se llenan las listas
        {
            try
            {
                do
                {
                    Console.Clear();
                    Console.Write("Ingrese un numero: ");
                    numero = Convert.ToDouble(Console.ReadLine());
                    Numeros.Add(numero);  //Pide ingresar un numero y lo agrega a la lista

                    Console.Write("¿Desea ingresar otro numero? (Y/N) "); //Pregunto si desea ingresar otro numero
                    opcion = Console.ReadLine().ToUpper();
                } while (opcion == "Y");
            }
            catch (Exception ex) //Por si ingresa un numero muy grande o no es un double.
            {
                Console.Write("Error encontrado, ingrese datos validos. . . ");
                Console.ReadKey();
                LlenarLista();
            }
        }

        private void ImprimirLista() //Metodo para imprimir la listas
        {
            int contador = 1;
            //Imprime la lista desordenado
            Console.Write("Lista no ordenada: \n");
            foreach (double numero in Numeros)
            {
                Console.WriteLine("{0} .- {1}", contador, numero);
                contador++;
            }
            Shell.ShellSort(Numeros); //Ordena la lista con el shellsort
            contador = 1;
            //Imprime la lista ordenada
            Console.Write("\n\nLista ordenada: \n");
            foreach (double numero in Numeros)
            {
                Console.WriteLine("{0} .- {1}", contador, numero);
                contador++;
            }
            Console.ReadLine();
        }

        public void Iniciar() //Para iniciar el programa
        {
            LlenarLista(); //LLena la lista y la imprime.
            ImprimirLista();
        }
    }
}
