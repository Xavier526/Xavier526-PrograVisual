using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenderReciclados
{
    class Cliente
    {
        private string nombre;
        private int RecicladosenKg;

        public Cliente(string nom)
        {
            nombre = nom;
            RecicladosenKg = 0;
        }

        public void Vender(int m)
        {
            RecicladosenKg = RecicladosenKg + m;
        }

        public void Pagar(int m)
        {
            RecicladosenKg = RecicladosenKg - m;
        }

        public int RetornarReciclaje()
        {
            return RecicladosenKg;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " Sus ganancias del reciclaje son " + RecicladosenKg);
        }
    }

   
}
