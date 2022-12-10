using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleCircular
{
    internal class Nodo
    {
        private int dato;
        private Nodo siguiente;
        private Nodo atras;
        public int Dato
            { get { return dato; } set { dato = value; } }
        public Nodo Siguiente 
            { get { return siguiente; } set { siguiente = value;  } }
        
        public Nodo Atras 
            { get { return atras; } set { atras = value;} }
        public Nodo()
        {
            dato= 0;
            siguiente = null;
            atras = null;
        }
        public Nodo(int dato, Nodo siguiente, Nodo atras)
        { 
            this.dato = dato; 
            this.siguiente = siguiente; 
            this.atras = atras;
        }
        public override string ToString()
        {
            return dato + " - " ;
        }
    }
}
