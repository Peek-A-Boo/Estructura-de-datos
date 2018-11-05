using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_2
{
    class ToDoList
    {
        List<Tareas> Terminadas = new List<Tareas>();
        List<Tareas> EnProceso = new List<Tareas>();
        List<Tareas> Global = new List<Tareas>();
        List<Tareas> Pendientes = new List<Tareas>(); //Listas para las tareas
        int id = 1;  //ID para las tareas
        int opcion = 0;
        string eleccion = "Y";
        
        public void menu() //Menu donde se dan las diferentes opciones
        {
            try
            {
                do
                {
                    Console.Clear();
                    Console.Write("----MENU----\n1)Mostrar Tareas\n2)Agregar Tarea\n3)Procesar Tarea\n4)Detener Tarea\n5)Corregir Tarea\n6)Terminar Tarea\n\nTu eleccion: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            MostrarTareas();
                            break;

                        case 2:
                            Console.Clear();
                            AgregarTarea();
                            break;

                        case 3:
                            Console.Clear();
                            ProcesarTarea();
                            break;

                        case 4:
                            Console.Clear();
                            DetenerTarea();
                            break;

                        case 5:
                            Console.Clear();
                            CorregirTarea();
                            break;

                        case 6:
                            Console.Clear();
                            TerminarTarea();
                            break;

                        default:
                            Console.Clear();
                            Console.Write("\n\nOpcion incorrecta.");
                            break;
                    }
                    Console.Write("Desea realizar otra operacion (Y/N)\nTu eleccion: ");
                    eleccion = Console.ReadLine().ToUpper();
                } while (eleccion == "Y");
                Console.Write("Saliendo del programa.");
                Console.ReadKey();
            }

            catch (Exception ex)
            {
                Console.Write("Error encontrado: {0}", ex.Message);
                Console.ReadKey();
            }
        }

        private void AgregarTarea()    //Metodo para agregar una tarea
        {
            Tareas Nueva = new Tareas();

            Nueva.ID = id;
            Console.Write("Ingrese nombre de la tarea: ");
            Nueva.Nombre = Console.ReadLine();
            Console.Write("Ingrese Descripcion de la tarea: ");
            Nueva.Descripcion = Console.ReadLine();
            Console.Write("Ingrese fecha de inicio: ");
            Nueva.FechaInicio = Console.ReadLine();
            Nueva.FechaFinalizado = "--------";  //Se piden los datos de la tarea
            do
            {
                Console.Write("¿La tarea sera pendiente(1) o estara en proceso(2)?");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Agregando tarea a pendientes. . .\n");
                        Nueva.Estado = "Pendientes";
                        Pendientes.Add(Nueva);
                        break;

                    case 2:
                        Console.Write("Agregando a tarea en procesos. . .\n");
                        Nueva.Estado = "En proceso";
                        EnProceso.Add(Nueva);
                        break;

                    default:
                        Console.Write("Opcion incorrecta intente de nuevo.\n");
                        break;
                }
            } while (opcion != 1 && opcion != 2);

            Global.Add(Nueva);
            id++;
        }

        private void ProcesarTarea()  //Se piden los datos para poner una tarea que estuviera en pendientes a en proceso.
        {
            foreach (Tareas Tarea in Pendientes)
            {
                Console.Write("ID: {0}\nNombre: {1}\nDescripcion: {2}\n", Tarea.ID, Tarea.Nombre, Tarea.Descripcion);
            }
            Console.Write("ingrese ID de la tarea a iniciar: ");  //Pide el ID para seleccionar una tarea
            int busqueda = Convert.ToInt32(Console.ReadLine());

            Tareas Cambio = new Tareas();
            Cambio = (from Consulta in Pendientes
                      where Consulta.ID == busqueda
                      select Consulta).ToList().ElementAt(0);      //Consulta para seleccionar la tarea con el ID seleccionado
            Global.Remove(Cambio);
            Pendientes.Remove(Cambio);
            Cambio.Estado = "En proceso";                    //Se edita la tarea quitando el elemento de las listas, editandolo y luego volviendolos a agregar.
            Global.Add(Cambio);
            EnProceso.Add(Cambio);
        }

        private void DetenerTarea()  //Se piden los datos para poner una tarea en proceso a pendiente
        {
            foreach (Tareas Tarea in EnProceso) //Despliega las tareas que esten en proceso
            {
                Console.Write("ID: {0}\nNombre: {1}\nDescripcion: {2}\n", Tarea.ID, Tarea.Nombre, Tarea.Descripcion);
            }

            Console.Write("Ingrese ID de la tarea a detener: "); //Pide el ID para seleccionar una tarea
            int busqueda = Convert.ToInt32(Console.ReadLine());

            Tareas Cambio = new Tareas();                       
            Cambio = (from Consulta in EnProceso
                      where Consulta.ID == busqueda                    //consulta para encontrar la tarea con el ID especificado
                      select Consulta).ToList().ElementAt(0);
            Global.Remove(Cambio);
            EnProceso.Remove(Cambio);
            Cambio.Estado = "Pendiente";
            Global.Add(Cambio);                         //Se edita la tarea quitando el elemento de las listas, editandolo y luego volviendolos a agregar.
            Pendientes.Add(Cambio);
        }

        private void CorregirTarea()  //Se piden los datos para poner una tarea de terminada a ya sea en proceso o pendiente.
        {
            foreach (Tareas Tarea in Terminadas)  //Despliega las tareas que esten terminadas
            {
                Console.Write("ID: {0}\nNombre: {1}\nDescripcion: {2}\n", Tarea.ID, Tarea.Nombre, Tarea.Descripcion);
            }
            Console.Write("Ingrese ID de la tarea a corregir: "); //Pide el ID para seleccionar una tarea
            int busqueda = Convert.ToInt32(Console.ReadLine());

            Tareas Cambio = new Tareas();
            Cambio = (from Consulta in Terminadas
                      where Consulta.ID == busqueda
                      select Consulta).ToList().ElementAt(0); //Busca la tarea con el id seleccionado
            Global.Remove(Cambio);
            Terminadas.Remove(Cambio);
            Cambio.FechaFinalizado= "--------";

            do
            {
                Console.Write("¿La tarea sera pendiente(1) o estara en proceso(2)?");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Agregando tarea a pendientes. . .\n");
                        Cambio.Estado = "Pendientes";
                        Pendientes.Add(Cambio);
                        break;

                    case 2:
                        Console.Write("Agregando a tarea en procesos. . .\n");
                        Cambio.Estado = "En proceso";
                        EnProceso.Add(Cambio);
                        break;

                    default:
                        Console.Write("Opcion incorrecta intente de nuevo.\n");
                        break;
                }
            } while (opcion != 1 && opcion != 2);
            Global.Add(Cambio);         //Se edita la tarea quitando el elemento de las listas, editandolo y luego volviendolos a agregar.
        }

        private void TerminarTarea() //Metodo para poner una tarea como terminada
        {
            foreach (Tareas Tarea in EnProceso)  //Despliega todas las tareas en proceso
            {
                Console.Write("ID: {0}\nNombre: {1}\nDescripcion: {2}\n", Tarea.ID, Tarea.Nombre, Tarea.Descripcion);
            }
            Console.Write("Ingrese ID de la tarea a corregir: "); //Pide el ID para poder seleccionar una tarea
            int busqueda = Convert.ToInt32(Console.ReadLine());

            Tareas Cambio = new Tareas();
            Cambio = (from Consulta in EnProceso
                      where Consulta.ID == busqueda
                      select Consulta).ToList().ElementAt(0);   //Consulta para seleccioanr una tarea en proceso.
            Global.Remove(Cambio);
            EnProceso.Remove(Cambio);
            Console.Write("Ingrese fecha de finalizado: ");
            Cambio.FechaFinalizado = Console.ReadLine();
            Cambio.Estado = "Terminada";
            Global.Add(Cambio);
            Terminadas.Add(Cambio);                      //Se edita la tarea quitando el elemento de las listas, editandolo y luego volviendolos a agregar.
        }

        private void MostrarTareas()   //metodo para poder desplegar las tareas en las diferentes listas.
        {
                Console.Write("¿Cuales tareas desea desplegar? \n1)Global\n2)En Proceso\n3)Pendientes\n4)Terminadas\nTu eleccion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\n");
                switch (opcion)
                {
                    case 1:
                        foreach(Tareas Tarea in Global)
                        {
                            Console.Write("ID: {0}\nNombre: {1}\nDescripcion: {2}\nEstado: {3}\nFecha de inicio: {4}\nFecha de finalizado: {5}\n", Tarea.ID,Tarea.Nombre, Tarea.Descripcion, Tarea.Estado, Tarea.FechaInicio, Tarea.FechaFinalizado);
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        foreach (Tareas Tarea in EnProceso)
                        {
                            Console.Write("ID: {0}\nNombre: {1}\nDescripcion: {2}\nEstado: {3}\nFecha de inicio: {4}\nFecha de finalizado: {5}\n", Tarea.ID,Tarea.Nombre, Tarea.Descripcion, Tarea.Estado, Tarea.FechaInicio, Tarea.FechaFinalizado);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        foreach (Tareas Tarea in Pendientes)
                        {
                            Console.Write("ID: {0}\nNombre: {1}\nDescripcion: {2}\nEstado: {3}\nFecha de inicio: {4}\nFecha de finalizado: {5}\n", Tarea.ID,Tarea.Nombre, Tarea.Descripcion, Tarea.Estado, Tarea.FechaInicio, Tarea.FechaFinalizado);
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        foreach (Tareas Tarea in Terminadas)
                        {
                            Console.Write("ID: {0}\nNombre: {1}\nDescripcion: {2}\nEstado: {3}\nFecha de inicio: {4}\nFecha de finalizado: {5}\n", Tarea.ID,Tarea.Nombre, Tarea.Descripcion, Tarea.Estado, Tarea.FechaInicio, Tarea.FechaFinalizado);
                        }
                        Console.ReadKey();
                        break;

                    default:
                        Console.Write("Opcion incorrecta intente de nuevo. . .");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
        }
    }
}
