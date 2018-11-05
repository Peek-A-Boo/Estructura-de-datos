using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_1
{
    class Hanoi
    {
        LinkedList<int> Torre1 = new LinkedList<int>();
        LinkedList<int> Torre2 = new LinkedList<int>();
        LinkedList<int> Torre3 = new LinkedList<int>(); //Crea las 3 torres que son listas enlazadas
        int discos = 0;                                 //Numero de discos en las torres
        int movimientos = 0;                            //Numero de movimientos
        string opcion = "Y";

        public void IniciarHanoi()                      //Metodo donde se hace el hanoi
        {
            try
            {
                do
                {


                    Console.Clear();
                    Console.Write("¿Cuantos discos tendras?");
                    discos = Convert.ToInt32(Console.ReadLine());   //Se ingresa el numero de discos
                    Console.Write("─────────────────────────────────────────────────────────────────────────────────────────────────────────\n\n");
                    LlenarTorre(); //Se llena la torre que tendra los discos ademas de reiniciar las variables.
                    AcomodarTorres(discos, ref Torre1, ref Torre2, ref Torre3, "1", "2", "3"); //Se llama el metodo recursivo para acomodar las torres
                    Console.Write("\n");
                    foreach (var item in Torre2)
                    {
                        Console.WriteLine(item);  //Despliega la torre completa
                    }
                    Console.Write("\nNumero de movimientos: {0}", movimientos); //Despliega el numero de movimientos
                    Console.ReadKey();

                    Console.Write("\n\n¿Desea realizar otra torre?(Y/N)\nTu eleccion: ");
                    opcion = Console.ReadLine().ToUpper();
                } while (opcion == "Y");
                Console.Write("Saliendo del programa . . .");
                Console.ReadLine();
            }

            catch(Exception ex)
            {
                Console.Write("Error encontrado: {0}", ex.Message);
                Console.ReadKey();
                IniciarHanoi();
            }
        }

        private void LlenarTorre() //Metodo para reiniciar las variables y objetos ademas de llenar la primera torre
        {
            Torre1.Clear();
            Torre2.Clear();
            Torre3.Clear();
            movimientos = 0;
            for (int contador = 1; contador <= discos; contador++)
            {
                Torre1.AddLast(contador);
            }
        }

        private void AcomodarTorres(int discos,ref LinkedList<int> torre1, ref LinkedList<int> torre2, ref LinkedList<int> torre3,string tor1, string tor2, string tor3)
        {  //Metodo recursivo donde se realiza el acomodo, los valores estan ordenados de modo que la torre1 es la fuente, la torre 2 es el destino y la torre 3 es la auxiliar.
            if(discos==1)
            {
                Console.WriteLine("Torre {0} -> Torre {1}",tor1,tor2); 
                torre2.AddLast(torre1.Last());  //Agrega el ultimo elemento a una torre ademas de quitar el ultimo elemento de la lista donde se haya movido el disco.
                torre1.RemoveLast();
                movimientos++; //Se suma el contador de movimientos.
            }
            else
            {
                AcomodarTorres(discos - 1,ref torre1, ref torre3, ref torre2,tor1,tor3,tor2); //Se llama el metodo recursivo pero esta vez con el orden de los elementos cambiado
                Console.WriteLine("Torre {0} -> Torre {1}",tor1,tor2);  
                torre2.AddLast(torre1.Last());  //Agrega el ultimo elemento a una torre ademas de quitar el ultimo elemento de la lista donde se haya movido el disco.
                torre1.RemoveLast();
                movimientos++; //Se suma el contador de movimientos
                AcomodarTorres(discos - 1, ref torre3, ref torre2, ref torre1,tor3,tor2,tor1); //Se llama el metodo recursivo pero esta vez con el orden de los elementos cambiado
            }
        }
    }
}
