using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07___Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random();
            List<int> numeros = new List<int>();
            Console.Write("Numeros no ordenados\n");
            for(int contador = 0;contador<Convert.ToInt32(azar.Next(1,100));contador++)
            {
                numeros.Add(azar.Next(1, 100));
                Console.Write("{0}\n", numeros.ElementAt(contador));
            }
            Console.Write("\n\nNumeros ordenados\n");
            var ordenados = numeros.OrderByDescending(n => n);
            foreach (var num in ordenados)
                Console.Write("{0}\n", num);
            Console.ReadLine();
        }
    }
}
