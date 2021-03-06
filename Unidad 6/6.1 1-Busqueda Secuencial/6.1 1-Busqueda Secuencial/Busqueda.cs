﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_1_Busqueda_Secuencial
{
    class Busqueda
    {

        public void Buscar(int[] Numeros, int numero)
        {
            List<int> Indices = new List<int>(); //Lista para guardar los indices encontrador

            for (int contador = 0; contador < (Numeros.Length - 1); contador++) //compara todos los elementos dentro de la coleccion
            {                                                                 //Con el elemento buscado. (Busqueda secuencial)
                if (Numeros[contador] == numero)
                {
                    Indices.Add(contador);
                }
            }

            if (Indices.Count < 1)
            {
                Console.WriteLine("El numero {0} no se encuentra dentro del arreglo", numero); //Si no hay ningun indice dentro de la lista
            }                                                                                 //Significa que el numero no se encuentra
            else
            {
                foreach (int elemento in Indices)                                           //Si hay elementos dentro de indice se imprimen los indices
                {
                    Console.WriteLine("El numero {0} esta en el indice: {1}", numero, elemento + 1);
                }
            }
        }
    }
}
