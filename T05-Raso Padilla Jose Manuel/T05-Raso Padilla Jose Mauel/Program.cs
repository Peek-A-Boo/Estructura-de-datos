using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace T05._Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch tiempo = Stopwatch.StartNew();
            long numero = 0;
            for (int contador = 0; contador < 1000001; contador++)
            {
                numero = numero + contador;
            }
            Console.Write("La suma fue: {0}\nTiempo de: {1}", numero, tiempo.Elapsed.TotalMilliseconds.ToString());
            Console.ReadKey();
        }
    }
}

