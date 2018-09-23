using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA02___Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero de sucesiones: ");
            int sucesiones = Convert.ToInt32(Console.ReadLine());
            string[] sucesion = new string[sucesiones];
            Console.Write("\n");
            for (int contador = 0; contador < sucesiones; contador++)
            {
                Console.Write("Ingrese elemento {0} de la sucesion: ", contador + 1);
                sucesion[contador] = Console.ReadLine();
            }
            Array.Reverse(sucesion);
            Console.Write("\nEl nuevo orden de los elementos es:\n\n");
            for (int contador = 0; contador < sucesiones; contador++)
            {
                Console.Write("El nuevo elemento {0} es: {1}", contador + 1,sucesion[contador]);
                sucesion[contador] = Console.ReadLine();
            }
        }
    }
}
