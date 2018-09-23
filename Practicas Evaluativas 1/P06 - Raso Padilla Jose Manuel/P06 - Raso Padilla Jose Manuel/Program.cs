using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06___Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero de sucesiones: ");
            int sucesiones = Convert.ToInt32(Console.ReadLine());
            string[] sucesion = new string[sucesiones];
            int mayor = 0;
            bool primeraVez = true;
            bool primerIndice = false;
            Console.Write("\n");
            for (int contador = 0; contador < sucesiones; contador++)
            {
                Console.Write("Ingrese elemento {0} de la sucesion: ", contador + 1);
                sucesion[contador] = Console.ReadLine();
                if (primeraVez == false && contador < sucesiones - 1 && primerIndice==false)
                {
                    if (sucesion[contador].Length > sucesion[contador - 1].Length)
                    {
                        mayor = contador;
                        primerIndice = true;
                    }
                }
                primeraVez = false;
            }
            if (mayor == 0)
                Console.Write("\n\nEl orden es no decreciente por lo tanto el indice es de: {0}", mayor);
            else
                Console.Write("\n\nEl indice del primer elemento mayor que su predecesor es: {0}", (mayor + 1));
            Console.ReadLine();
        }
    }
}
