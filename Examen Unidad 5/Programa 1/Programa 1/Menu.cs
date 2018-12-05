using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_1
{
    class Menu
    {
        int numero = 0;
        List<int> Numeros = new List<int>();
        string opcion = "Y";
        Proceso Burbuja = new Proceso();

        private void LlenarLista() //Metodo para llenar la lista
        {
            try
            {
                do
                {
                    Console.Clear();
                    Console.Write("Ingrese un numero del 0 al 2: "); //Ingresa un numero del 0-2
                    numero = Convert.ToInt32(Console.ReadLine());
                    if ((numero >= 0) && (numero <= 2))
                    {
                        Numeros.Add(numero); //Si esta entre 0 y 2 lo agrega
                    }
                    else //Si no, pide ingresar otro numero
                    {
                        Console.Write("\n\nIngrese un numero entero valido entre 0 y 2");
                        Console.ReadKey();
                        LlenarLista();
                    }
                    Console.Write("¿Desea ingresar otro numero? (Y/N) "); //Pregunta si quiere ingresar otro numero.
                    opcion = Console.ReadLine().ToUpper();
                } while (opcion == "Y");
            }
            catch(Exception ex) //Por si no ingresa un numero y en cambio ingresa otro tipo de dato
            {
                Console.Write("Error encontrado, ingrese datos validos. . . ");
                Console.ReadKey();
                LlenarLista();
            }

        }

        private void ImprimirLista() //metodo para imprimir listas
        {
            int contador = 1;
            //Imprime la lista desordenado
            Console.Write("Lista no ordenada: \n");
            foreach (int numero in Numeros)
            {
                Console.WriteLine("{0} .- {1}", contador, numero);
                contador++;
            }
            Burbuja.BurbujitaBB(Numeros); //Ordena la lista con el metodo de la burbuja
            contador = 1;
            //Imprime la lista ordenada
            Console.Write("\n\nLista ordenada: \n");
            foreach (int numero in Numeros)
            {
                Console.WriteLine("{0} .- {1}", contador, numero);
                contador++;
            }
            Console.ReadLine();
        }

        public void Iniciar() //metodo para iniciar el programa, llena la lista y luego la imprime.
        {
            LlenarLista();
            ImprimirLista();
        }
    }
}
