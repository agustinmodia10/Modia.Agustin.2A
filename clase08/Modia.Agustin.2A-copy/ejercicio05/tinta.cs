using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    class tinta
    {
        private  ConsoleColor color;
        private etipotinta etipotinta;
         
        public  tinta()
        {
            this.color = ConsoleColor.Blue;
            this.etipotinta = etipotinta.conBrillito;
        }


        public void estrablecertinta(ConsoleColor a)
        {
            this.color = a;
          
        }

        //public void estrablecertinta(string a, Double b)
        //{
        //    this.cadena = a;
        //    this.numero = b;
        //}


        private string Mostrar()
        {
            string retorno = "";

            retorno = this.color + "\n" + "\n" + this.etipotinta + "\n";

            return retorno;

        }
    }
}
