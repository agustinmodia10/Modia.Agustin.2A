using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasee05
{
    class tinta
    {
        private ConsoleColor color;
        private etipotinta etipotinta;

        public tinta()
        {
            this.color = ConsoleColor.Blue;
            this.etipotinta = etipotinta.conBrillito;
        }


        public tinta(ConsoleColor a) : this()
        {
            this.color = a;

        }

        public tinta(ConsoleColor a, etipotinta b) : this(a)
        {
            this.etipotinta = b;

        }



        public static string Mostrar(tinta a)
        {
            return a.mostrar();


        }

        private string mostrar()
        {
            string retorno = "";
            retorno = this.color + "--" + this.etipotinta;


            return retorno;
        }



        public static bool operator == (tinta a, tinta b)
            {
            bool retorno = false;

            if( a.color== b.color && a.etipotinta == b.etipotinta)
            {

                retorno = true;

            }
            return retorno;
            }

        public static bool operator !=(tinta a, tinta b)
        {
            



            return !( a == b);
        }


    }
}
