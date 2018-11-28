using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_Quicksort
{
    class Menu
    {
        Quicksort Metodo = new Quicksort();

        public Menu()
        {

        }

        public void Iniciar()
        {
            Console.Write("Lista 1: \n");
            NumerosUno();
            Console.Write("\n\nLista 2: \n");
            NumerosDos();
            Console.Write("\n\nLista 3: \n");
            NumerosTres();
            Console.Write("\n\nLista 4: \n");
            NumerosCuatro();
        }

        private void NumerosUno() //Metodo para la lista 1
        {
            //11,2,3,14,18,45,-3,-1,6,9
            List<double> Lista1 = new List<double>();
            Lista1.Add(11);
            Lista1.Add(2);
            Lista1.Add(3);
            Lista1.Add(14);
            Lista1.Add(18);
            Lista1.Add(45);
            Lista1.Add(-3);
            Lista1.Add(-1);
            Lista1.Add(6);
            Lista1.Add(9);
            Metodo.Ordenar(Lista1, 0, Lista1.Count - 1); //Ordena la lista
            Imprimir(Lista1); //Imprime la lista ordenada
            Console.ReadKey();
        }

        private void NumerosDos() //Metodo para la lista 2
        {
            //1,3,5,7,8,3,9,.7071,16.5664,12,0,10
            List<double> Lista2 = new List<double>();
            Lista2.Add(1);
            Lista2.Add(3);
            Lista2.Add(5);
            Lista2.Add(7);
            Lista2.Add(8);
            Lista2.Add(9);
            Lista2.Add(0.7071);
            Lista2.Add(16.5664);
            Lista2.Add(12);
            Lista2.Add(0);
            Lista2.Add(10);
            Metodo.Ordenar(Lista2, 0, Lista2.Count - 1); //Ordena la lista
            Imprimir(Lista2); //Imprime la lista
            Console.ReadKey();
        }

        private void NumerosTres() //Metodo para la lista 3
        {
            // 3,7,15,4/3,155,100,15,sqrt(3),5,2,3,2
            List<double> Lista3 = new List<double>();
            Lista3.Add(3);
            Lista3.Add(7);
            Lista3.Add(15);
            Lista3.Add(1.3333333);
            Lista3.Add(155);
            Lista3.Add(100);
            Lista3.Add(15);
            Lista3.Add(Math.Pow(3,0.5));
            Lista3.Add(5);
            Lista3.Add(2);
            Lista3.Add(3);
            Lista3.Add(2);
            Metodo.Ordenar(Lista3, 0, Lista3.Count - 1); //Ordena la lista
            Imprimir(Lista3); //Imprime la lista
            Console.ReadKey();
        }

        private void NumerosCuatro() //Metodo para la lista 4
        {
            //8,19,7,3,15,23,34,27,89,101
            List<double> Lista4 = new List<double>();
            Lista4.Add(8);
            Lista4.Add(19);
            Lista4.Add(7);
            Lista4.Add(3);
            Lista4.Add(15);
            Lista4.Add(23);
            Lista4.Add(34);
            Lista4.Add(27);
            Lista4.Add(89);
            Lista4.Add(101);
            Metodo.Ordenar(Lista4, 0, Lista4.Count - 1); //Ordena la lista
            Imprimir(Lista4); //Imprime la lista
            Console.ReadKey();
        }

        public void Imprimir(List<double> Numeros) //Metodo para imprimir la lista.
        {
            foreach (double elemento in Numeros)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
