using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_3
{
    class Proceso
    {
        public void ShellSort(List<double> Numeros)
        {
            int longitud=Numeros.Count(); //Longitud de la lista
            int mitad = longitud / 2; //La mitad de la lista para separarla en dos
            double temporal; //Variable temporal para intercambiar numeros

            while (mitad > 0) //Mientras que la mitad sea mas de 0 (que tenga mitad) 
            {
                for (int contador = 0; contador < longitud-mitad; contador++) //Realiza el ciclo for dentro de una mitad
                {
                    int contador2 = contador + mitad; //el contador2 es el contador 1 mas la mitad (segunda mitad)
                    temporal = Numeros[contador2]; //Variable temporal se le asigna el primer elemento de una mitad

                    while ((contador2 - mitad >= 0) && (temporal < Numeros[contador2 - mitad])) //Intercambia los elementos previamente ordenados.  
                    {   
                        Numeros[contador2] = Numeros[contador2 - mitad]; //Intercambia los elementos buscados en la mitad hasta que la localizacion correcta para 
                        contador2 = contador2 - mitad;                  //el elemento en la lista sea encontrado
                    }

                    Numeros[contador2] = temporal; //Se asigna la variable temporal al numero con el indice del contador 2
                }

                mitad = mitad / 2; //se vuelve a separar en mas mitades
            }
        }
    }
}
