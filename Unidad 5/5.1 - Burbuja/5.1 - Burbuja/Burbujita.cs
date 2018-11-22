using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1___Burbuja
{
    class Burbujita
    {
        List<int> numeritos = new List<int>();
        int tempy = 0;

        private void BurbujitaBB() //Metodo donde se realiza el metodo de la burbuja
        {
            for (int contador1 = 0; contador1 < numeritos.Count(); contador1++) //Primer ciclo donde se hace cuantas veces se repetira el otro for
            {
                for (int contador2 = 1; contador2 < numeritos.Count(); contador2++) //Segundo ciclo donde se hacen las comparaciones
                {
                    if(numeritos[contador2] < numeritos[contador2-1]) //Si el elemento con indice mayor es menor se invierten
                    {
                        tempy = numeritos[contador2]; //Variable temporal para guardar el numero que vamos a reemplazar
                        numeritos[contador2] = numeritos[contador2 - 1]; //Se asigna el valor al indice mayor el del indice anterior
                        numeritos[contador2 - 1] = tempy; //Guarda el elemento previamente cambiado;
                    }
                }
            }
        }
        public void Procesar()
        {
            try
            {
                string opcion = "Y"; //Variable de eopcion
                do
                {
                    Console.Clear(); //Limpia la consola despues de cada intento
                    Console.Write("Ingrese un numero: "); //para desplegar un numero
                    numeritos.Add(Convert.ToInt32(Console.ReadLine())); //Agrega el numero a la lista
                    Console.Write("¿Desea ingresar otro numero? (Y/N): "); //Pregunta si desea ingresar otro numero
                    opcion = Console.ReadLine().ToUpper(); //Pide la opcion
                } while (opcion == "Y");

                Console.Write("fuera de orden: \n"); //Imprime antes de hacerlo con el metodo de la burbuja
                foreach(int weaita in numeritos)
                {
                    Console.Write("{0} ", weaita);
                }

                BurbujitaBB();

                Console.Write("\nEn orden: \n"); //Imprime despues de hacerle el metodo de la burbuja.
                foreach(int weaita in numeritos)
                {
                    Console.Write("{0} ", weaita);
                }
            }
            
            catch (Exception ex) 
            {
                Console.Write("Error encontrado: {0}", ex.Message);
                Console.ReadLine();
                Procesar();
            }
        }
    }
}
