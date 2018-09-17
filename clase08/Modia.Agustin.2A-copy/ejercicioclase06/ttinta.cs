using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioclase06
{
    class ttinta
    {

        private ConsoleColor color;
        private etipotinta etipotinta;

        public ttinta()
        {
            this.color = ConsoleColor.Blue;
            this.etipotinta = etipotinta.conBrillito;
        }


        public ttinta(ConsoleColor a) : this()
        {
            this.color = a;

        }

        public ttinta(ConsoleColor a, etipotinta b) : this(a)
        {
            this.etipotinta = b;

        }



        public static string Mostrar(ttinta a)
        {
            return a.mostrar();


        }

        private string mostrar()
        {
            string retorno = "";
            retorno = this.color + "--" + this.etipotinta;
            ;

            return retorno;
        }



        public static bool operator ==(ttinta a, ttinta b)
        {
            bool retorno = false;


            if (a.color == b.color && a.etipotinta == b.etipotinta)
            {

                retorno = true;

            }
            return retorno;
        }

        public static bool operator !=(ttinta a, ttinta b)
        {




            return !(a == b);


        }
    }
}
