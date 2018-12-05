using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_1
{
    class Proceso
    {
        int tempy = 0;

        public void BurbujitaBB(List<int> Numeritos) //Metodo donde se realiza el metodo de la burbuja
        {
            for (int contador1 = 0; contador1 < Numeritos.Count(); contador1++) //Primer ciclo donde se hace cuantas veces se repetira el otro for
            {
                for (int contador2 = 1; contador2 < Numeritos.Count(); contador2++) //Segundo ciclo donde se hacen las comparaciones
                {
                    if (Numeritos[contador2] < Numeritos[contador2 - 1]) //Si el elemento con indice mayor es menor se invierten
                    {
                        tempy = Numeritos[contador2]; //Variable temporal para guardar el numero que vamos a reemplazar
                        Numeritos[contador2] = Numeritos[contador2 - 1]; //Se asigna el valor al indice mayor el del indice anterior
                        Numeritos[contador2 - 1] = tempy; //Guarda el elemento previamente cambiado;
                    }
                }
            }
        }
    }
}
