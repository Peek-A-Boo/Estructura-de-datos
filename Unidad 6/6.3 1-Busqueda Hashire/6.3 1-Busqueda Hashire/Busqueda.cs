using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3_1_Busqueda_Hashire
{
    class Busqueda
    {
        int[] Arreglo; //Crea las variables auxiliares para el programa
        int elemento = 0;
        int indice = 0;
        bool bandera = false;

        public void BuscarHashire(List<int> Numeros , int elementoBuscado) //Metodo para buscar con funcion HASHire sori yo kaze no you ni tsukimihara wo PADORU PADORU
        {
            bandera = false;
            int size = Numeros.Count;
            Arreglo = new int[size]; //Arreglo donde se almacenaran los elementos con una funcion

            for (int contador = 0; contador < size; contador++)
            {
                Arreglo[contador] = -1; //Se llena el arreglo de -1 para decir que dicho elemento esta vacio
            }

            for (int contador = 0; contador < Numeros.Count; contador++) //Se llena el arreglo donde se ordenaran los elementos dentro de la lista
            {
                elemento = Numeros[contador];
                indice = Convert.ToInt32(elemento % (size)); //Se realiza con la funcion del modulo del elemento y del tamaño

                while (Arreglo[indice] != -1) //Si el elemento ya esta ocupado se movera una casilla el indice. (Colisiones)
                {
                    indice++;
                }

                Arreglo[indice] = elemento; //Se almacena el elemento dentro del arreglo hash
            }

            indice = Convert.ToInt32(elementoBuscado % (Numeros.Count - 1)); //Realiza la operacion para conseguir el indice del elemento.
            int contadorWea = 0; //Contador para que no se cicle la busqueda hash
            while ((Arreglo[indice] != -1) && (bandera == false))
            {
                if (Arreglo[indice]==elementoBuscado) //Si se encuentra el elemento buscado se entra a esta condicion
                {
                    Console.Write("\n{0} si existe y esta en el indice {1}", elementoBuscado, indice+1);
                    bandera = true; //Despliega el mensaje de que si existe y la bandera se vuelve verdadera.
                }
                else //Si no se encuentra el elemento significa que tal vez un elemento tomo su lugar debido a una colision y debera moverse una casilla.
                {
                    indice++;
                    indice %= size; //Suma el indice y realiza su modulo con el tamaño.
                    contadorWea++;
                    if(contadorWea>size) //para prevenir un ciclo infinito.
                    {
                        Console.Write("\nEl elemento {0} no existe dentro de la funcion", elementoBuscado);
                        bandera = true;
                    }
                }
            }
            
            Console.Write("\nElementos dentro de la funcion hash:\n"); //Despliega los elementos dentro del arreglo hash.
            contadorWea = 1;
            foreach(int numero in Arreglo)
            {
                Console.WriteLine("{0}.- {1}", contadorWea, numero);
                contadorWea++;
            }
            Console.ReadLine();
        }

    }
}
