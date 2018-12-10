using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_1_Busqueda_Binaria
{
    class Menu
    {
        List<int> Numeros = new List<int>(); //Variables auxiliares para el programa
        string opcion = "Y";
        int numero = 0;
        Busqueda Objeto = new Busqueda();
        int elemento = 0;

        public void Iniciar() //Metodo para iniciar el programa
        {
            try
            {
                Console.Clear();
                while (opcion == "Y")
                {
                    Console.Clear();
                    Console.Write("Ingrese un numero entero: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Numeros.Add(numero);
                    Console.Write("\n¿Desea ingresar otro numero? (Y/N)\n"); //Pide un numero, lo añade a la lista y despues pregunta si agregara otro.
                    opcion = Console.ReadLine().ToUpper();
                }
                Console.Clear();
                Console.Write("¿Que elemento desea buscar? ");
                elemento = Convert.ToInt32(Console.ReadLine()); //Pide un elemento para buscar
                Objeto.BuscarBinario(Numeros, 0, Numeros.Count - 1, elemento); //LLama al metodo para hacer la busqueda binaria.
            }
            catch(Exception ex)
            {
                Console.Clear();
                Console.Write("Error encontrado, ingrese los datos correctamente.");
                Console.ReadLine();
                Iniciar();

            }
        }
    }
}
