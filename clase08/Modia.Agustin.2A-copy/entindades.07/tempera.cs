using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entindades._07
{
    public class tempera
    {
        #region  atributos y contructores
        sbyte cantidad;
        ConsoleColor color;
        string marca;

        public tempera(ConsoleColor a, sbyte b, string c)
        {
            this.color =a;
            this.marca = c;
            this.cantidad = b;
        }
        #endregion

        //public tempera(ConsoleColor a) : this()
        //{
        //    this.color = a;

        //}

        //public tempera(ConsoleColor a, sbyte b) : this(a)
        //{
        //    this.cantidad = b;

        //}

        //public tempera(ConsoleColor a, sbyte b, string c) : this(a,b)
        //{
        //    this.marca = c;

        //}






        private string mostrar()
        {
            string retorno = "";


            if ((object) this== null )
            {
                Console.WriteLine("error no se ha cargado la tempera vuelva a intentarlo");

            }

            if ((object)this != null)
            {

              retorno = this.marca + "--" + this.cantidad + "--"  + this.color;

            }

            return retorno;
        }





        #region sobrecargas
        public static implicit operator string(tempera n)
        {

            return n.mostrar();

        }

        public static explicit operator sbyte(tempera n)
        {
            sbyte retorno = n.cantidad;

            return retorno;

        }

        public static bool operator ==(tempera a, tempera b)
        {
            bool retorno = false;


            if (a.color == b.color && a.marca == b.marca)
            {

                retorno = true;

            }
            return retorno;
        }

        public static bool operator !=(tempera a, tempera b)
        {




            return !(a == b);
        }

        public static tempera operator +(tempera a, sbyte b)

        {

            tempera temp = new tempera(a.color, (sbyte)(a.cantidad + b), a.marca);

            
            return temp;
        }

        public static tempera operator +(tempera a, tempera b)
        {
            tempera c = new tempera(a.color, a.cantidad, a.marca);

            if (a == b)
            {

                c += a.cantidad;

            }


            return c;
        }

        //public static tempera operator -(tempera a, sbyte b)

        //{

        //    tempera temp = new tempera(a.color, (sbyte)(a.cantidad - b), a.marca);


        //    return temp;
        //}

        //public static tempera operator -(tempera a, tempera b)
        //{
        //    tempera c = new tempera(a.color, a.cantidad, a.marca);

        //    if (a == b)
        //    {

        //        c -= a.cantidad;

        //    }


        //    return c;
        //}

        #endregion


    }
}
