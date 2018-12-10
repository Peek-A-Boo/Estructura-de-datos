using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_2_Busqueda_Secuencial
{
    class Menu
    {
        public void Iniciar()
        {
            List<string> Palabras = new List<string>(); //Variables auxiliares para el programa
            string opcion = "Y";
            string palabra = "";
            Busqueda Objeto = new Busqueda();
            string elemento = "";

            try
            {
                Console.Clear();
                while (opcion == "Y") //Metodo iterativo para llenar la lista
                {
                    Console.Clear();
                    Console.Write("Ingrese una palabra: ");
                    palabra = Console.ReadLine();
                    Palabras.Add(palabra);
                    Console.Write("\n¿Desea ingresar otra palabra? (Y/N)\n"); //Ingresa una palabra, la añade a la lista y pregunta si ingresara otra.
                    opcion = Console.ReadLine().ToUpper();
                }
                Console.Clear();
                Console.Write("¿Que palabra desea buscar? "); //Pregunta la palabra a buscar
                elemento = Console.ReadLine();
                Objeto.Buscar(Palabras,elemento); //Busca la palabra en cuestion
                Console.ReadKey();
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
