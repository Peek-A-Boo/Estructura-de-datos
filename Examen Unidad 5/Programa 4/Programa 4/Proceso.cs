using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_4
{
    class Proceso
    {
                /* ALGORITMO (introduction to algorithms 3rd edition)
         * QUICKSORT (A, p, r)
            if p < r
                q = PARTITION(A, p, r)
                QUICKSORT(A, p, q-1)
                QUICKSORT(A, q+1, r)

            PARTITION(A, p, r)
                x=A[r]
                i=p-1
                for j = p to r - 1
                    if A <= x
                        i = i + 1
                        exchange A[i] with A[j]
                exchange A[i+1] with A[r]
                return i + 1
         */
        int pivoteUbicacion = 0;
        int contador = 0;

        public void Ordenar(List<string> ListaPalabras, int indiceMenor, int indiceMayor) //Metodo recursivo del quicksort
        {
            if (indiceMenor<indiceMayor)
            {
                pivoteUbicacion = Particionar(ListaPalabras, indiceMenor, indiceMayor); //Metodo para ubicarl pivote
                Ordenar(ListaPalabras, indiceMenor, pivoteUbicacion - 1); //Metodos recursivos para ordenar
                Ordenar(ListaPalabras, pivoteUbicacion + 1, indiceMayor);
            }
        }

        private int Particionar(List<string> ListaPalabras, int indiceMenor, int indiceMayor) //Metodo para particionar el arreglo/lista y regresa la ubicacion del pivote
        {
            string pivote = ListaPalabras[indiceMayor]; //El pivote siempre sera el indice mas alto
            contador = indiceMenor - 1; //Contador que regresara la localizacion del pivote
            for (int contador2 = indiceMenor; contador2 < indiceMayor; contador2++) //proceso comparativo iterativo del metodo quicksort
            {
                if(string.Compare(ListaPalabras[contador2],pivote)<0) //Si el pivote es mayor que el elemento comparado
                {
                    contador = contador + 1; //suma 1 a la localizacion del pivote
                    Intercambiar(ListaPalabras, contador, contador2); //Intercambia los dos elementos
                }
            }
            Intercambiar(ListaPalabras, contador + 1, indiceMayor); //Intercambia el indice mayor con la posicion del pivote
            return (contador + 1); //Regresa la ubicacion del pivote
        }

        private void Intercambiar(List<string> ListaNumeros, int indiceUno, int indiceDos) //Metodo para intercambiar dos elementos 
        {
            string temporal = ListaNumeros[indiceUno]; //Se guarda el elemento antes de intercambiarlo
            ListaNumeros[indiceUno] = ListaNumeros[indiceDos]; //Se sustituye el elemento de la lista con el otro
            ListaNumeros[indiceDos] = temporal; //Se asigna el nuevo valor del indice dos ahora usando la variable temporal
        }

    }
}
