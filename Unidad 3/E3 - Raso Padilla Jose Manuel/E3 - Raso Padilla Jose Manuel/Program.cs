using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3___Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion wea = new Operacion();
            string bandera = "Y";
            string opcion = "";
            do
            {
                Console.Clear();
                Console.Write("-Menu del programa-\n\n1)Ejercicio 1\n2)Ejercicio 2\n3)Ejercicio 3\n4)Ejercicio 4\n");
                Console.Write("\n\nTu eleccion: ");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Write("\nEjecutando programa 1:"); //Ejecuta programa 1
                        Console.ReadKey();
                        Console.Clear();
                        wea.Ejercicio1();
                        break;

                    case "2":
                        Console.Write("\nEjecutando programa 2:");  //ejecuta programa 2
                        Console.ReadKey();
                        Console.Clear();
                        wea.Ejercicio2();
                        break;

                    case "3":
                        Console.Write("\nEjecutando programa 3:"); //ejecuta programa 3
                        Console.ReadKey();
                        Console.Clear();
                        wea.Ejercicio3();
                        break;

                    case "4":
                        Console.Write("\nEjecutando programa 4:"); //ejecuta programa 4
                        Console.ReadKey();
                        Console.Clear();
                        wea.Ejercicio4();
                        break;

                    default:
                        Console.Write("Opcion no valida intente de nuevo"); //Se le pide ingresar otra opcion
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.Write("¿Desea ejecutar otro programa? (Y/N):  "); //Se le pregunta si quiere ejecutar otro programa
                bandera = Console.ReadLine().ToUpper();
            } while (bandera == "Y");
            Console.Write("Saliendo del programa."); //Se sale del programa
            Console.ReadLine();
        }
    }
}
