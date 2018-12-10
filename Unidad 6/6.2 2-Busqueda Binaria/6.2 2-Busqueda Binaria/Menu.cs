using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_2_Busqueda_Binaria
{
    class Menu
    {
        List<string> Palabras = new List<string>(); //Variables auxiliares para el programa
        string opcion = "Y";
        string palabra = "";
        Busqueda Objeto = new Busqueda();
        string elemento = "";

        public void Iniciar() //Metodo para iniciar el programa
        {
            try
            {
                Console.Clear();
                while (opcion == "Y")
                {
                    Console.Clear();
                    Console.Write("Ingrese una palabra: ");
                    palabra = Console.ReadLine();
                    Palabras.Add(palabra);
                    Console.Write("\n¿Desea ingresar otra palabra? (Y/N)\n");
                    opcion = Console.ReadLine().ToUpper(); //Pide una palabra, la agrega a la lista y posteriormente pregunta si quiere ingresar otra.
                }
                Console.Clear();
                Console.Write("¿Que palabra desea buscar? ");
                elemento = Console.ReadLine();
                Objeto.BuscarBinario(Palabras, 0, Palabras.Count - 1, elemento); //Pide un elemento a buscar y llama al metodo para buscarla.
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.Write("Error encontrado, ingrese los datos correctamente.");
                Console.ReadLine();
                Iniciar();

            }
        }
    }
}
