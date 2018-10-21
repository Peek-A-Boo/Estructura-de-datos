using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_3_Raso_Padilla_Jose_Manuel
{
    class BlackJack
    {
        //Se crean las variables del blackjack
        List<Carta> naipes = new List<Carta>();           //Lista donde se almacena los objetos carta (baraja)
        Random azar = new Random();           //Variable azar para poder generar un numero al azar
        Stack mano = new Stack();             //Pila donde se almacena la mano
        Carta carta;                         //objeto donde se almacena la carta
        int indice = 0;                       //Entero para indice de la carta
        int total = 0;                        //Entero donde se almacena la suma total
        int aces = 0;                         //Entero donde se almacena el numero de aces en la mano  
        int rounds = 0;                       //Entero donde se almacena los rounds jugados
        string opcion = "Y";

        //Metodo para barajear
        private void Barajear()
        {
            //Se limpia la mano y naipes del programa
            mano.Clear();
            naipes.Clear();
            rounds = 0;
            //Ciclo para los naipes del 1-10
            for (int contador = 1; contador < 11; contador++)
            {
                carta = new Carta();
                carta.Simbolo = "♥-" + contador;
                carta.Valor = contador;
                naipes.Add(carta);
                carta = new Carta();
                carta.Simbolo = "♠-" + contador;
                carta.Valor = contador;
                naipes.Add(carta);
                carta = new Carta();
                carta.Simbolo = "♦-" + contador;
                carta.Valor = contador;
                naipes.Add(carta);
                carta = new Carta();
                carta.Simbolo = "♣-" + contador;
                carta.Valor = contador;
                naipes.Add(carta);
            }
            //Cartas Jota
            carta = new Carta();
            carta.Simbolo = "♥-J";
            carta.Valor = 10;
            naipes.Add(carta);
            carta = new Carta();
            carta.Simbolo = "♠-J";
            carta.Valor = 10;
            naipes.Add(carta);
            carta = new Carta();
            carta.Simbolo = "♦-J";
            carta.Valor = 10;
            naipes.Add(carta);
            carta = new Carta();
            carta.Simbolo = "♣-J";
            carta.Valor = 10;
            naipes.Add(carta);
            //Cartas Reina
            carta = new Carta();
            carta.Simbolo = "♥-Q";
            carta.Valor = 10;
            naipes.Add(carta);
            carta = new Carta();
            carta.Simbolo = "♠-Q";
            carta.Valor = 10;
            naipes.Add(carta);
            carta = new Carta();
            carta.Simbolo = "♦-Q";
            carta.Valor = 10;
            naipes.Add(carta);
            carta = new Carta();
            carta.Simbolo = "♣-Q";
            carta.Valor = 10;
            naipes.Add(carta);
            //Cartas rey
            carta = new Carta();
            carta.Simbolo = "♥-K";
            carta.Valor = 10;
            naipes.Add(carta);
            carta = new Carta();
            carta.Simbolo = "♠-K";
            carta.Valor = 10;
            naipes.Add(carta);
            carta = new Carta();
            carta.Simbolo = "♦-K";
            carta.Valor = 10;
            naipes.Add(carta);
            carta = new Carta();
            carta.Simbolo = "♣-K";
            carta.Valor = 10;
            naipes.Add(carta);
        }

        //Metodo para jugar que recibe como parametro las victorias, derrotas y juegos
        public void Jugar(ref int victorias, ref int derrotas, ref int juegos)
        {
            //Cada vez que se inicia una partida se limpia la mano y baraja ademas de que la baraja se vuelve a llenar.
            Barajear();
            //Se roban dos naipes al iniciar el juego.
            RobarNaipe();
            do
            {
                Console.Clear();
                RobarNaipe(); //Roba un naipe
                Desplegarmano(); //Roba, despliega y compara el numero nuevamente.
                Comparar(); //suma el total obtenido hasta el momento
                Console.Write("Total: {0}\n\n", total); //Despliega el total.
                if ((total <= 20) && (mano.Count < 5)) //Si tiene una mano que es de menos de 5 cartas y suman menos de 21 se le permite sacar otra carta
                {
                    try
                    {
                        Console.Write("¿Desea robar una carta? (Y/N)\n");
                        opcion = Console.ReadLine().ToUpper();
                    }
                    catch(Exception e)
                    {
                        Console.Write("Error encontrado: {0}", e.Message);
                        Console.ReadLine();
                    }
                }
            } while ((mano.Count < 5) && (total <= 20) && (opcion=="Y")); //Si la mano llega a 5 cartas o el total pasa de 20 se sale del ciclo

            if (total > 21)   // si pasa de 21 se pierde el juego, se despliega el mensaje de derrota y se suma el contador de derrotas.
            {
                Console.Write("Has perdido");
                derrotas++;
            }
            else if ((total<=21) && (mano.Count==5))           //si no paso de 21 o tiene 21 y tiene menos de 5 cartas
            {                                                   //significa que gano el juego, despliega el mensaje de victoria y suma el contador de victorias.
                Console.Write("Has ganado");
                victorias++;
            }
            else if (total==21)                                //Si suma 21 gana el juego sin importar el numero de cartas
            {
                Console.Write("Has ganado");
                victorias++;
            }
            else                                                //En todos los demas casos resulta en una derrota
            {
                Console.Write("Has perdido");
                derrotas++;
            }
            juegos++; //Se suma el contador de juegos jugados cuando ya se acabo la sesion.
        }
        //Metodo para sacar una carta
        private void RobarNaipe()
        {
            indice = azar.Next(0, naipes.Count); //se selecciona un indice al azar para sacar la carta de la pila
            mano.Push(naipes.ElementAt(indice)); //Se agrega a la pila de la mano la carta obtenida
            //Quita el elemento de la lista que tiene el mismo simbolo que el naipe sacado de la lista y lo asigna a la baraja.
            naipes = (from naipe in naipes where naipe.Simbolo != naipes.ElementAt(indice).Simbolo select naipe).ToList();     
        }
        //Metodo para poder tener la suma de las cartas
        private void Comparar()
        {
            total = 0; //La suma total se convierte a 0
            foreach (Carta objeto in mano) //Por cada carta en la mano realizara lo que esta dentro del ciclo
            {
                if ((objeto.Valor>=2) && (objeto.Valor<=10)) //Si el valor de la carta esta entre 2 y 10
                {
                    total = total + objeto.Valor; //el total se suma con el valor que tenga la carta
                }
                else
                {
                    aces = aces + 1;  //si es az entonces se guarda en un contador para los aces que sera usado mas adelante
                }
            }

            for(aces=aces;aces > 0;aces--) //Por cada az dentro de la mano realizara este ciclo
            {
                if ((total+11)>21)          //Si el az hace que la mano pase de 21  si vale 11
                {
                    total = total+1;        //Se le asigna el valor del az como 1
                }
                else                         //Si el az no hace que la mano no pase de 21 si vale 11
                {
                    total = total + 11;       //Se asigna el valor del az como 11
                }
            }
        }
        //Metodo para desplegar la mano
        private void Desplegarmano()
        {
            rounds++;                       //Se suma 1 al round
            Console.Write("Tu mano en round {0}:\n",rounds);        //Despliega el mensaje
            foreach (Carta objeto in mano)
            {
                Console.Write(objeto.Simbolo +"\n");          //por cada carta en la pila mano la despliega.
            }
        }

    }
}
