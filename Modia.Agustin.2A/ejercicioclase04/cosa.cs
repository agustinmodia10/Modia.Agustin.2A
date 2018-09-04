using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioclase04
{
    class cosa
    {
        #region atributos
        public string cadena;

        public  double numero;


       public  DateTime fecha;
        #endregion


        #region metodos

        public static string Mostrar(cosa a )
        {
            string retorno = "";
            
           //retorno =  a.cadena + "\n" + a.numero.ToString() + "\n"  + a.fecha.ToLongDateString() + "\n";
           
            return a.Mostrar() ;
        }


        private  string Mostrar()
        {
            string retorno = "";

            retorno = this.cadena + "\n" + this.numero.ToString() + "\n" + this.fecha.ToLocalTime() + "\n";

            return retorno;

        }

         public void EstablecerValor(string a )
        {
            this.cadena = a;
            
        }

        public void EstablecerValor(string a, Double b)
        {
            this.cadena = a;
            this.numero = b;
        }
        public void EstablecerValor(string a, Double b, DateTime c)
        {
            this.cadena = a;
            this.numero = b;
            this.fecha = c;
        }
        #endregion

        #region constructores 
        public cosa  ()
        {
            this.cadena = "sin valor";
            this.numero = 1.9;
            this.fecha = DateTime.Now;

        }

        public cosa( string a) : this()
        {
            this.cadena = a;
           

        }

        public cosa(string a, int b) : this(a)
        {
            this.numero = b;

        }

        public cosa(string a, int b, DateTime c) : this(a, b)
        {
            this.fecha = c;

        }
        #endregion
    }
}
