using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE2_1_Raso_Padilla_Jose_Manuel;
using PE2_2_Raso_Padilla_Jose_Manuel;
using PE2_3_Raso_Padilla_Jose_Manuel;

namespace PE2___Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            string programa = "";
            string opcion = "Y";
            Menor Programa1 = new Menor();
            Mayor Programa2 = new Mayor();
            Ordenamiento Programa3 = new Ordenamiento();
            do
            {
                Console.Clear();
                Console.Write("----Seleccione el programa que desea abrir----\n\n1)Programa de algoritmo recursivo para encontrar el minimo en una sucesion finita de numeros\n2)Programa de algoritmo recursivo para encontrar el maximo en una sucesion finita de numeros\n3)Programa de algoritmo recursivo para invertir un vector\n\nTu eleccion: ");
                programa = Console.ReadLine();
                Console.Clear();
                if (programa == "1")
                    Programa1.RealizaOperacion();
                else if (programa == "2")
                    Programa2.RealizaOperacion();
                else if (programa == "3")
                    Programa3.RealizaOperacion();
                else
                    Console.Write("Ingrese una opcion correcta");

                Console.Write("Desea Realizar otra operacion? (Y/N)");
                opcion = Console.ReadLine().ToUpper();
            } while (opcion == "Y");
            Console.Write("Saliendo del programa. . . ");
            Console.ReadLine();
        }
    }
}
