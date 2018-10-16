using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2_Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea la cola
            Queue weaita = new Queue();

            //Enqueue Agrega elementos al final de la cola.
            weaita.Enqueue("Nico");
            weaita.Enqueue(true);
            weaita.Enqueue(42);
            weaita.Enqueue(7.19);
            weaita.Enqueue('c');
            Console.WriteLine("1.- " + weaita.Count);

            //Dequeue quita el ultimo elemento dentro de la cola y lo manda  (similar a pop)
            Console.WriteLine("2.- "+ weaita.Dequeue().ToString() + " -- " + weaita.Count);

            //TrimToSize pone la capacidad de la cola como el numero de elementos que tiene en el momento reduciendo la carga en memoria.
            weaita.TrimToSize();

            //Peek regresa el primer valor que haya sido ingresado dentro de la cola, diferente a stack
            //porque este imprime el ultimo agregado y stack el mas reciente.
            Console.WriteLine("3.- "+ weaita.Peek());

            
            //Debido al comportamiento del enqueue esta vez el MoveNext del IEnumerator los imprime 
            //en el orden que fueron agregados a la cola.
            IEnumerator ejemplo = weaita.GetEnumerator();
            while (ejemplo.MoveNext())
            {
                Object objeto = ejemplo.Current;
                Console.WriteLine("4.-" + objeto);
            }
            Console.ReadKey();

            //Los metodos de ToString, ToArray y contains son practicamente lo mismo a los de stack asi que
            //Por esa razon no se encuentran en este ejemplo (Se deben poner solo las diferentes)
        }
    }
}
