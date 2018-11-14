using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Menu
    {
        public void DesplegarMenu()
        {
            try
            {
                int opcion = 0;
                string bandera = "";
                do
                {
                    Console.Clear();
                    Console.Write("--Menu--");
                    Console.Write("\n1) Arbol 1\n2) Arbol 2\n3) Arbol 3\nTu eleccion: ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Arbol1 arbolin1 = new Arbol1();
                            arbolin1.RealizarOperacion();
                            Console.ReadKey();
                            break;

                        case 2:
                            Arbol2 arbolin2 = new Arbol2();
                            arbolin2.RealizarOperacion();
                            Console.ReadKey();
                            break;

                        case 3:
                            Arbol3 arbolin3 = new Arbol3();
                            arbolin3.RealizarOperacion();
                            Console.ReadKey();
                            break;

                        default:
                            Console.Write("Opcion incorrecta intente de nuevo");
                            Console.ReadKey();
                            break;
                    }
                    Console.Write("¿Desea ver otro arbol? (Y/N)");
                    bandera = Console.ReadLine().ToUpper();
                } while (bandera == "Y");
             }

            catch (Exception ex)
            {
                Console.Write("Error encontrado: {0}", ex.Message);
                Console.ReadKey();
                DesplegarMenu();
            }
        }
    }
}
