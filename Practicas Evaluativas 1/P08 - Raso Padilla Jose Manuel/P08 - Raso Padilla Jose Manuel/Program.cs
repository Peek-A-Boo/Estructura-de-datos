using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08___Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            int palindromo = 0;
            Console.Write("Ingrese numero de 5 digitos: ");
            palindromo = Convert.ToInt32(Console.ReadLine());
            bool condicion = true;
            do
            {
                if (palindromo >= 10000 && palindromo <= 99999)
                {
                    char[] reves = palindromo.ToString().ToCharArray();
                    int palindromoReves = Convert.ToInt32(Convert.ToString(reves[4]) + Convert.ToString(reves[3]) + Convert.ToString(reves[2]) + Convert.ToString(reves[1]) + Convert.ToString(reves[0]));
                    if (palindromoReves == palindromo)
                        Console.Write("\n\n{0} == {1} por lo tanto es palindromo",palindromo,palindromoReves);
                    else
                        Console.Write("\n\n{0} =/= {1} por lo tanto no es palindromo", palindromo, palindromoReves);
                    condicion = false;
                    Console.ReadLine();
                }
                else
                    IngresaNumero();
            }while (condicion ==true);

            void IngresaNumero()
            {
                Console.Clear();
                Console.Write("ERROR\n\nIngrese numero de 5 digitos: ");
                palindromo = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
