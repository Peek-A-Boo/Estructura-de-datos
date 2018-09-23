using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA04___Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[3];
            Console.Write("Ingrese numero a: ");
            numeros[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese numero b: ");
            numeros[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese numero c: ");
            numeros[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("El numero menor entre a,b,c es: {0}", numeros.Min());
            Console.ReadLine();
        }
    }
}
