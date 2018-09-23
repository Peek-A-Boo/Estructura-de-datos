using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03___Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero de sucesiones: ");
            int sucesiones = Convert.ToInt32(Console.ReadLine());
            double[] numeros = new double[sucesiones];
            Console.Write("\n");
            for (int contador = 0; contador < sucesiones; contador++)
            {
                Console.Write("Ingrese numero {0} de la sucesion: ", contador + 1);
                numeros[contador] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("\nEl indice con el elemento mas grande es: {0}", (numeros.ToList().LastIndexOf(numeros.Max()) + 1));
            Console.ReadLine();
        }
    }
}
