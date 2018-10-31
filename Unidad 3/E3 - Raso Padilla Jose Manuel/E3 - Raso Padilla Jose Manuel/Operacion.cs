using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.CSharp;

namespace E3___Raso_Padilla_Jose_Manuel
{
    public class Operacion
    {
        Stack Lista = new Stack();
        Queue Cola = new Queue();
        LinkedList<object> WeaitaEnlazada = new LinkedList<object>();
        List<object> WeaitaNormal = new List<object>();
        List<Clase> Salon = new List<Clase>();
        List<Clase> consulta = new List<Clase>();

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Lista.Clear();  //Se limpia la pila al iniciar
            Lista.Push(5);
            Lista.Push(3);  //Se realiza el proceso de agregar y sacar
            Lista.Pop();
            Lista.Push(2);
            Lista.Push(8);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(9);
            Lista.Push(1);
            Lista.Pop();
            Lista.Push(7);
            Lista.Push(6);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(4);
            Lista.Pop();
            Lista.Pop();

            foreach(object wea in Lista) //Por cada elemento restante lo imprimira
            {
                Console.Write("Elemento: {0}\n", wea);
            }
            Lista.Clear();  //Limpia la pila para que quede vacia nuevamente.
        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            string opcion = "Y";
            string cadena = "";
            LinkedList<string> Literales = new LinkedList<string>();   //Lista enlazada para literales
            LinkedList<string> PalabrasReservadas = new LinkedList<string>();  //Lista enlazada para palabras reservadas

            CSharpCodeProvider Comparador = new CSharpCodeProvider();  //Objeto para poder identificar si tiene una palabra reservada el codigo
            do
            {
                Console.Clear();
                Console.Write("Ingrese una cadena: ");  //Se ingresa una cadena
                cadena = Console.ReadLine();
                if(Comparador.IsValidIdentifier(cadena))    //Si la palabra escrita es un identificador y no una palabra reservada ejecuta el if
                {                                           //y la agrega a la lista de literales
                    Console.Write("No es palabra reservada\n");
                    Literales.AddLast(cadena);
                }
                else                                     //Si la palabra escriba es una palabra reservada se ejecuta el siguiente codigo
                {                                       //y la agrega a la lista de palabras reservadas
                    Console.Write("Es palabra reservada\n");
                    PalabrasReservadas.AddLast(cadena);
                }
                Console.Write("Desea escribir otra palabra? (Y/N): ");    //Se le pregunta al usuario si quiere ingresar otra palabra
                opcion = Console.ReadLine().ToUpper();
            } while (opcion == "Y");
            Console.Clear();

            foreach (string item in PalabrasReservadas)
            {
                Console.WriteLine(item);
            }
            Console.Write("Palabras reservadas escritas: {0}\n", PalabrasReservadas.Count());   //Escribe el numero de palabras reservadas escritas
            foreach (string item in Literales)
            {
                Console.WriteLine(item);
            }
            Console.Write("Literales escritas: {0}", Literales.Count());                        //Escribe el numero de literales escritas
            Literales.Clear();
            PalabrasReservadas.Clear(); //Limpia ambas listas enlazadas
        }

        public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            var tiempoNormal = Stopwatch.StartNew(); //Inicia el timer
            for (int contador = 0; contador < 9876; contador++)
            {
                WeaitaNormal.Add("Waifus"); //Agrega los 9876 elementos a la lista normal
            }
            tiempoNormal.Stop(); //Detiene el timer para la lista normal

            var tiempoEnlazada = Stopwatch.StartNew(); //Inicia el timer para la lista enlazada
            for (int contador = 0; contador < 9876; contador++)  //Agrega los 9876 elementos a la lista enlazada
            {
                WeaitaEnlazada.AddFirst("Waifus");   
            }
            tiempoEnlazada.Stop();  //Detiene el timer para la lista enlazada

            Console.Write("El tiempo de ejecucion en una lista normal: {0}\n", tiempoNormal.Elapsed.TotalMilliseconds);  //Escribe el tiempo de ejecucion de la lista normal
            Console.Write("El tiempo de ejecucion en una lista Enlazada: {0}\n", tiempoEnlazada.Elapsed.TotalMilliseconds); //Escribe el tiempo de ejecucion de la lista enlazada
            WeaitaEnlazada.Clear();
            WeaitaNormal.Clear();  //Limpia la lista normal y la lista enlazada
        }

        public void Ejercicio4()
        {
            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            try
            {
                string maestro = "";
                string materia = "";
                Console.Write("Ingrese nombre del maestro: "); //Ingresa el nombre del maestro y la materia que imparte
                maestro = Console.ReadLine();
                Console.Write("Ingrese materia del curso: ");
                materia = Console.ReadLine();
                Console.Write("Cuantos alumnos va a ingresar (minimo deben de ser 30):"); //Escribe el numero de alumnos que tiene dicho maestro
                int cantidad = Convert.ToInt32(Console.ReadLine());

                if (cantidad >= 30)  //Si son mas o igual de 30 se ejecuta el programa
                {
                    for (int contador = 0; contador < cantidad; contador++)
                    {
                        Clase objClase = new Clase();  //Se crea un objeto para cada alumno
                        Console.Write("Ingrese nombre del alumno {0}: ",contador+1);
                        objClase.Alumno = Console.ReadLine();
                        Console.Write("Ingrese califacion del alumno {0}: ",contador+1);
                        objClase.Calificacion = Convert.ToInt32(Console.ReadLine());
                        objClase.Maestro = maestro;
                        objClase.NombreClase = materia;  //Se llena sus propiedades
                        Salon.Add(objClase);  //y se agrega a la lista
                    }

                    Console.Clear();
                    Console.Write("Mayores\n"); //Imprime los mayores
                    Mayor();
                    Console.Write("Menores\n");  //Imprime los menores
                    Menor();
                    Console.Write("Promedio\n"); //Imprime el promedio
                    Promedio();
                    Salon.Clear(); //Limpia la lista de salon
                }
                else
                {
                    Console.Clear();  
                    Console.Write("Ingrese al menos 30 alumnos");  //Si no ingreso 30 o mas se le pide que ingrese 30 o mas
                    Console.ReadLine();
                    Console.Clear();
                    Ejercicio4();
                }
            }
            catch (Exception e)
            {
                Console.Write("Error encontrado: {0}", e.Message);
            }

        }

        private void Mayor() //Metodo para las mayores calificaciones
        {
            Salon = (from wea in Salon
                     orderby wea.Calificacion descending
                     select wea).ToList(); //Ordena la lista descendentemente
            foreach(Clase objeto in Salon)
            {
                if (objeto.Calificacion==Salon[0].Calificacion) //Compara si el elemento en cuestion es el mayor para imprimirlo
                {
                    Console.Write("El nombre del alumno con la mejor calificacion fue: {0}\n", objeto.Alumno);
                    Console.Write("La calificacion del alumno con la mejor calificacion fue: {0}\n", objeto.Calificacion);
                }
            }
        }

        private void Menor() //Metodo para la menores calificaciones
        {
            Salon = (from wea in Salon
                     orderby wea.Calificacion ascending
                     select wea).ToList(); //Ordena la lista ascendentemente
            foreach (Clase objeto in Salon)
            {
                if (objeto.Calificacion == Salon[0].Calificacion) //Compara si el elemento en cuestion es el menor para imprimirlo
                {
                    Console.Write("El nombre del alumno con la menor calificacion fue: {0}\n", objeto.Alumno);
                    Console.Write("La calificacion del alumno con la menor calificacion fue: {0}\n", objeto.Calificacion);
                }
            }
        }

        private void Promedio() //metodo para calcular el promedio
        {
            double acumulador = 0;
            foreach (Clase Objeto in Salon)
            {
                acumulador = acumulador + Objeto.Calificacion; //Suma todas las calificaciones dentro de la lista y al final la divide entre el numero de alumnos.
            }
            Console.Write("El promedio de la materia de {0} impartida por {1} fue de: {2}",Salon[0].NombreClase,Salon[0].Maestro,acumulador / Salon.Capacity);
        }
    }
}
