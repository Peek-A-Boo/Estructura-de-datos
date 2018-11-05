using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_3
{
    class Solucion
    {
        /* Supongamos que Bob tiene cuatro vacas que quiere cruzar por un puente, pero solo un yugo, que puede sostener hasta dos vacas, 
        * lado a lado, atadas al yugo. El yugo es demasiado pesado para que lo lleve a través del puente, pero puede atar (y desatar) 
        * vacas a él en muy poco tiempo. De sus cuatro vacas, Mazie puede cruzar el puente en 2 minutos, Daisy puede cruzarlo en 4 minutos, 
        * Crazy puede cruzarlo en 10 minutos y Lazy puede cruzar en 20 minutos. Por supuesto, cuando dos vacas están atadas al yugo, 
        * deben ir a la velocidad de la vaca más lenta. 
         * Describe cómo Bob puede conseguir que todas sus vacas crucen el puente en 34 minutos*/

        List<Vacas> Lado1 = new List<Vacas>();
        List<Vacas> Lado2 = new List<Vacas>(); //Se crea la lista de las vacas
        int vueltas = 0;   //Para contar las vueltas y el tiempo
        int tiempo = 0;


        public Solucion()  //Con el constructor se crean todas las vaquitas con las propiedades de velocidad y nombre
        {
            Vacas Vaca = new Vacas();
            Vaca.Nombre = "Mazie";
            Vaca.Velocidad = 2;
            Lado1.Add(Vaca);
            Vaca = new Vacas();
            Vaca.Nombre = "Daisy";
            Vaca.Velocidad = 4;
            Lado1.Add(Vaca);
            Vaca = new Vacas();
            Vaca.Nombre = "Crazy";
            Vaca.Velocidad = 10;
            Lado1.Add(Vaca);
            Vaca = new Vacas();
            Vaca.Nombre = "Lazy";
            Vaca.Velocidad = 20;
            Lado1.Add(Vaca);
            Vaca = new Vacas();
        }

        public void Proceso()
        {
            while (Lado2.Count < 4) //Mientras el lado2(el otro lado del rio) no tenga 4 vacas realiza el ciclo
            {
                if (vueltas == 0)  //En la primera vuelta debe mandar a las dos vacas con la mayor velocidad(menor tiempo que toman en llegar al otro lado del rio)
                {
                    Lado1 = (from vaquita in Lado1
                             orderby vaquita.Velocidad ascending
                             select vaquita).ToList(); //Ordena la lista acorde a sus velocidades
                    Lado2.Add(Lado1.ElementAt(0));
                    Lado2.Add(Lado1.ElementAt(1));  //Agrega las dos vacas al otro lado del rio
                    tiempo = tiempo + Lado1.ElementAt(1).Velocidad; //El tiempo es el de la vaca mas lenta entre las dos
                    Console.Write("LLeva a {0} y a {1} haciendo {2} minutos (tiempo total: {3} minutos)", Lado1.ElementAt(0).Nombre, Lado1.ElementAt(1).Nombre, Lado1.ElementAt(1).Velocidad,tiempo);
                    Lado1.RemoveAt(0);
                    Lado1.RemoveAt(0); //Quita las dos vacas del lado 1 ya que se fueron al lado 2
                    tiempo = tiempo + Lado2.ElementAt(0).Velocidad;  //Para regresar al lado 1 necesita una vaca y se lleva a una de las del lado 2
                    Lado1.Add(Lado2.ElementAt(0)); //Y suma su velocidad al tiempo total ademas de quitarla del lado 2 y regresarla al lado1
                    Console.Write("\nRegresa a {0} haciendo {1} minutos (tiempo total: {2} minutos)", Lado2.ElementAt(0).Nombre, Lado2.ElementAt(0).Velocidad,tiempo);
                    Lado2.RemoveAt(0);
                }
                else
                {
                    Lado1 = (from vaquita in Lado1
                             orderby vaquita.Velocidad descending
                             select vaquita).ToList(); //En la segunda vuelta ordena en descendiente para llevarse a las dos vacas mas lentas
                    Lado2.Add(Lado1.ElementAt(0));
                    Lado2.Add(Lado1.ElementAt(1)); //Agrega ambas vacas al lado 2
                    tiempo = tiempo + Lado1.ElementAt(0).Velocidad; //Y pone la velocidad de la mas lenta
                    Console.Write("\nLLeva a {0} y a {1} haciendo {2} minutos (tiempo total: {3} minutos)", Lado1.ElementAt(0).Nombre, Lado1.ElementAt(1).Nombre, Lado1.ElementAt(0).Velocidad, tiempo);
                    Lado1.RemoveAt(0);
                    Lado1.RemoveAt(0); //Quita las dos vacas del lado 1
                    Lado2 = (from vaquita in Lado2
                             orderby vaquita.Velocidad ascending
                             select vaquita).ToList();  //Ordena las vacas del lado 2 de manera ascendente para regresarse con la vaca de mayor velocidad
                    if (Lado2.Count < 4)
                    { //Si ya tiene 4 vacas del lado 2 no tiene sentido regresar pero si no debe regresar por la restantes
                        tiempo = tiempo + Lado2.ElementAt(0).Velocidad;  //Suma el tiempo la velocidad de la vaca con la que regresa
                        Lado1.Add(Lado2.ElementAt(0)); //Agrega al lado 1 la vaca del lado 2
                        Console.Write("\nRegresa a {0} haciendo {1} minutos (tiempo total: {2} minutos)", Lado2.ElementAt(0).Nombre, Lado2.ElementAt(0).Velocidad,tiempo);
                        Lado2.RemoveAt(0); //Y quita la vaca del lado 2
                    }
                }
                vueltas++; //Suma las vueltas
            }
            Console.Write("\n\nTiempo total: {0} minutos", tiempo); //Despliega el tiempo total
        }

    }
}
