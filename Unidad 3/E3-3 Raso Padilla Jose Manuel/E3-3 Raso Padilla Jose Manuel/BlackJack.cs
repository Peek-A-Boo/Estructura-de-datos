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
        ArrayList auxiliar = new ArrayList(); //Lista auxiliar para poder quitar una carta de la pila
        Stack naipes = new Stack();           //Pila donde se almacena la baraja
        Random azar = new Random();           //Variable azar para poder generar un numero al azar
        Stack mano = new Stack();             //Pila donde se almacena la mano
        object carta;                         //objeto donde se almacena la carta
        int indice = 0;                       //Entero para indice de la carta
        int total = 0;                        //Entero donde se almacena la suma total
        int aces = 0;                         //Entero donde se almacena el numero de aces en la mano  
        int rounds = 0;                       //Entero donde se almacena los rounds jugados

        //Metodo para barajear
        private void Barajear()
        {
            //Se limpia la mano y naipes del programa
            mano.Clear();
            naipes.Clear();
            rounds = 0;
            //Ciclo para los naipes del 1-11
            for (int contador = 1; contador < 11; contador++)
            {
                naipes.Push("♠-" + contador.ToString());
                naipes.Push("♥-" + contador.ToString());
                naipes.Push("♦-" + contador.ToString());
                naipes.Push("♣-" + contador.ToString());
            }
            naipes.Push("♠-J");
            naipes.Push("♥-J");
            naipes.Push("♦-J");
            naipes.Push("♣-J");
            naipes.Push("♠-Q");
            naipes.Push("♥-Q");
            naipes.Push("♦-Q");
            naipes.Push("♣-Q");
            naipes.Push("♠-K");
            naipes.Push("♥-K");
            naipes.Push("♦-K");
            naipes.Push("♣-K");
        }
        //Metodo para jugar que recibe como parametro las victorias, derrotas y juegos
        public void Jugar(ref int victorias,ref int derrotas,ref int juegos)
        {
            //Cada vez que se inicia una partida se limpia la mano y baraja ademas de que la baraja se vuelve a llenar.
            Barajear();
            //Se roban dos naipes al iniciar el juego.
            RobarNaipe();
            RobarNaipe();
            //Despliega la mano
            Desplegarmano();
            //Compara si se obtuvo un 21 al iniciar (cambia el valor de total en la clase.
            Comparar();
            Console.Write("Total: {0}\n\n", total); //Escribe el total del robo inicial.
            if (total == 21)
            {
                //Si obtuvo 21 se gana el juego, se despliega el mensaje y se suma el contador de victorias.
                Console.Write("Has ganado");
                victorias++;
            }
            else
            { //Si no obtuvo 21 vuelve a robar una carta de la baraja
                do
                {
                    RobarNaipe();
                    Desplegarmano(); //Roba, despliega y compara el numero nuevamente.
                    Comparar();
                    Console.Write("Total: {0}\n\n", total); //Despliega el total.
                } while ((mano.Count < 5) && (total <= 20)); //Si la mano llega a 5 cartas o el total pasa de 20 se sale del ciclo

                if (total > 21)   // si pasa de 21 se pierde el juego, se despliega el mensaje de derrota y se suma el contador de derrotas.
                {
                    Console.Write("Has perdido");
                    derrotas++;
                }
                else            //si no paso de 21 significa que gano el juego, despliega el mensaje de victoria y suma el contador de victorias.
                {
                    Console.Write("Has ganado");
                    victorias++;
                }
                juegos++; //Se suma el contador de juegos jugados cuando ya se acabo la sesion.
            }
        }
        //Metodo para sacar una carta
        private void RobarNaipe()
        {
            auxiliar.Clear(); //Se limpia la lista auxiliar donde se guardan todas las cartas antes de sacar todos los elementos  de la pila
            indice = azar.Next(0, naipes.Count); //se selecciona un indice al azar para sacar la carta de la pila
            carta = naipes.ToArray().ElementAt(indice); //Se asigna la carta con el indice obtenido
            mano.Push(carta); //Se agrega a la pila de la mano la carta obtenida

            for(int contador=naipes.Count;contador>0;contador--) 
            {
                auxiliar.Add(naipes.Pop());  //Se sacan todos los elementos dentro de la pila y se agregan dichos elementos a la lista auxiliar con Pop
            }
            auxiliar.Remove(carta); //Saca la carta seleccionada de la lista auxiliar
            foreach (object objeto in auxiliar)
            {
                naipes.Push(objeto); //Se vuelve a llenar la pila con la lista auxiliar pero ya con la carta seleccionada removida.
            }
        }
        //Metodo para poder tener la suma de las cartas
        private void Comparar()
        {
            string[] valor = new string[3]; //arreglo de string donde se obtendra el valor de la carta
            total = 0; //La suma total se convierte a 0
            foreach (object objeto in mano) //Por cada carta en la mano realizara lo que esta dentro del ciclo
            {
                valor = objeto.ToString().Split('-'); //Debido a que las cartas las tengo como "(simbolo)-(valor)" uso el caracter "-" para hacer split

                if(int.TryParse(valor[1],out int res)) //Si lo que se intenta convertir es entero significa que puede valer de 1-11 ademas de que
                {                                      //no ocurrira un error de formato al intentar transformar una letra
                    if ((Convert.ToInt32(valor[1]) >= 2) && (Convert.ToInt32(valor[1]) <= 10)) //Si el valor obtenido del split esta entre 2 y 10
                    {
                        total = total + Convert.ToInt32(valor[1]); //el total simplemente se suma con el numero que tenga
                    }
                    else
                    {
                        aces = aces + 1;  //si es az entonces se guarda en un contador para los aces que sera usado mas adelante
                    }
                }
                else
                {
                    total = total + 10; //si no era un valor numerico el valor obtenido significa que puede ser un J,Q o K y siempre valen 10
                }
            }

            for(aces=aces;aces >0;aces--) //Por cada az dentro de la mano realizara este ciclo
            {
                if ((total+11)>21)          //Si el az hace que la mano pase de 21  si vale 11
                {
                    total = total+1;        //Se le asigna el valor del az como 1
                }
                else                         //Si el az no hace que la mano no pase de 21 si vale 11
                {
                    total = total+11;       //Se asigna el valor del az como 11
                }
            }
        }
        //Metodo para desplegar la mano
        private void Desplegarmano()
        {
            rounds++;                       //Se suma 1 al round
            Console.Write("Tu mano en round {0}:\n",rounds);        //Despliega el mensaje
            foreach (object objeto in mano)
            {
                Console.Write(objeto.ToString()+"\n");          //por cada carta en la pila mano la despliega.
            }
        }

    }
}
