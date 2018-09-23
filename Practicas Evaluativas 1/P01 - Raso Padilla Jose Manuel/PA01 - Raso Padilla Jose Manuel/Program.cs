using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA01___Raso_Padilla_Jose_Manuel
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
                numeros[contador] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\n\nEl numero mayor de la sucesion es: {0}\n", numeros.Max());
            Console.Write("El numero menor de la sucesion es: {0}", numeros.Min());
            Console.ReadLine();
        }
    }
}
