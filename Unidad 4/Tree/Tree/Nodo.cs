using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Nodo
    {
        public List<Nodo> Hijos = new List<Nodo>();
        public string Padre { get; set; }
        public int Valor { get; set; }
        public string Letra { get; set; }
        public int Nivel { get; set; }

        public Nodo(int dato,string letra)
        {
            Hijos = new List<Nodo>();
            this.Valor = dato;
            this.Letra = letra;

        }

        public Nodo(int dato, string letra, int nivel)
        {
            Hijos = new List<Nodo>();
            this.Valor = dato;
            this.Letra = letra;
            this.Nivel = nivel;
        }

    }
}
