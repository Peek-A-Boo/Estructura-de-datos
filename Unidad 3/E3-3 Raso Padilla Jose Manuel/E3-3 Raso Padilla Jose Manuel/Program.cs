using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_3_Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; //Para que la consola pueda desplegar unicode
            BlackJack Wea = new BlackJack();           //Objeto de la clase blackjack donde se tiene los procesos
            string opcion = "Y";                       //Opcion por default que es  Y
            int victorias = 0;                         //Contador de victorias
            int derrotas = 0;                          //Contador de derrotas
            int juegos = 0;                            //Contador de Juegos
            string opcion2 = "0";                      //Opcion para elegir ver estadisticas o jugar

            do
            {
                try
                {

                    Console.Clear(); //Limpia la consola al inicio del ciclo
                    Console.Write("♠♥♦♣ blackjack ♠♥♦♣");
                    Console.Write("\n1)Jugar\n2)Ver estadisticas\nTu Opcion: ");  //Menu del programa
                    opcion2 = Console.ReadLine();
                    if (opcion2 == "1") //Si selecciona 1 se ejecuta el juego
                    {
                        Console.Clear();
                        Wea.Jugar(ref victorias, ref derrotas, ref juegos);
                        Console.Write("\n\n¿Desea regresar al menu? (Y/N)\n");
                        opcion = Console.ReadLine().ToUpper();
                    }
                    else if (opcion2 == "2") //Si selecciona 2 se despliega las estadisticas
                    {
                        Console.Clear();
                        Console.Write("♠♥♦♣ Juegos: {0} ♠♥♦♣\n♠♥♦♣ Victorias: {1} ♠♥♦♣\n♠♥♦♣Derrotas: {2} ♠♥♦♣\n\n", juegos, victorias, derrotas);
                        Console.Write("\n\n¿Desea regresar al menu? (Y/N)\n");
                        opcion = Console.ReadLine().ToUpper();
                    }
                    else //Si no selecciono ninguna de las dos despliega opcion incorrecta
                    {
                        Console.Clear();
                        Console.Write("Opcion incorrecta volver a intentar");
                        Console.ReadKey();
                        opcion = "Y";
                    }
                }

                catch (Exception e)
                {
                    Console.Write("error encontrado: {0}", e.Message);
                    opcion = "Y";
                }
            } while (opcion == "Y");
            Console.Clear(); //Limpia la consola cuando ya no desea jugar
            Console.Write("Sus estadisticas fueron: \n\n♠♥♦♣ Juegos: {0} ♠♥♦♣\n♠♥♦♣ Victorias: {1} ♠♥♦♣\n♠♥♦♣Derrotas: {2} ♠♥♦♣\n\n", juegos, victorias, derrotas);
            //Despliega las estadisticas antes de salir.
            Console.ReadKey();
        }
    }
}
