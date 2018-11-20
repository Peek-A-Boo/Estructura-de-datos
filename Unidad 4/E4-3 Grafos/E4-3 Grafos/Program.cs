using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3_Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Grafo wea = new Grafo();
                wea.RecorrerAnchura();
                Console.ReadLine();
                wea.RecorrerProfundidad();
                Console.ReadKey();
            }

            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
