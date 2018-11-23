using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Menu
    {

        int contador = 0;
        double contadorCartas = 0;
        double primerasSemanas = 0;
        Arbol Arbolito = new Arbol();
        double cartasTotales = 0;
        int numeroCartas = 0;

        public Menu(int valor)
        {
            numeroCartas = valor;
            IngresarCartas(numeroCartas);
        }

        private void IngresarCartas(int valor) //Metodo para ingresar las cartas al arbol
        {
            if (contador < 7)
            {
                contador++;
                Arbolito.Agregar(valor); //Se ingresan en el arbol los valores
                IngresarCartas(valor);
            }
        }

        private void ObtenerCartas(int valor) //Metodo para obtener el numero de cartas
        {

            for (int contador2 = 0; contador2 < Math.Pow(5, 6); contador2++) //Suma todas las cartas enviadas
            {
                contadorCartas = contadorCartas + valor;
            }

            for (int contador2 = 0; contador2 < Math.Pow(5, 3); contador2++)
            {
                primerasSemanas = primerasSemanas + valor;     //Hace la suma de las 3 primeras semanas
            }
        }

        public void Iniciar() //metodo para realizar las operaciones
        {
            ObtenerCartas(numeroCartas);
            Console.Write("Cartas enviadas los ultimos 3 domingos: {0}\n", (contadorCartas - primerasSemanas) * 2); //Se resta el numero de cartas en total el numero de cartas de las primeras semanas para sacar las utimas 3
            Console.Write("Cartas enviadas en total las 7 semanas: {0}", (contadorCartas*2)); //Al ser dos personas las que iniciaron la cadena se multiplica por 2
            Console.ReadLine();
        }

    }
}
