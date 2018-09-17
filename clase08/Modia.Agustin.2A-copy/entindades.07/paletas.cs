using System;
using System.Collections.Generic;
using System.Text;

namespace entindades._07
{
  public  class paletas
    {

        #region atributos
        tempera[] colores;
        int cantmaxelementos;
        #endregion


        #region contructores


        private paletas(int a)
        {
            this.cantmaxelementos = a;
            this.colores = new tempera[this.cantmaxelementos];

        }

               private paletas () : this(5)
        {
            
        }
        #endregion


        #region metodos 

        private string mostrar()
        {
            

            string retorno="cantidad maxima de elementos :" + this.cantmaxelementos + " \n\n";

            foreach (tempera item in this.colores)

            {
                retorno = " \n " + retorno +  item + "\n" ;


            }


            return retorno;
        }


        public static explicit operator string(paletas n)
        {

            return n.mostrar();

        }

        public static implicit operator paletas (int n)
        {
            paletas h = new paletas(n);



            return h;

        }

        #endregion

        #region sobrecargas

        public static bool operator ==(paletas a, tempera b)
        {
            bool retorno = false;

            for (int i = 0; i < a.cantmaxelementos; i++)
            {
                if (a.colores.GetValue(i) != null)
                {
                    if (b == a.colores[i])
                    {

                        retorno = true;
                            
                        break;
                    }
                }

            }


            return retorno;
        }

        public static bool operator !=(paletas a, tempera b)
        {




            return !(a == b);
        }



        public static paletas operator + (paletas a , tempera b )
        {
            int indice = -1;
            
            if( a == b)
            {
                indice = a.encuentroindice(b);
                a.colores[indice] += b;

            }

            else
            {
                indice = a.encuentroindice();
                if(indice >-1)
                {
                    a.colores[indice] = b;
                }

              
            }



            return a;

        }

        public static paletas operator -(paletas a, tempera b)
        {

            int indice = -1;
          
          
             sbyte cant = (sbyte)b;
            sbyte cantp;

            if (a == b)
            {
                indice = a.encuentroindice(b);
                 cantp = (sbyte)a.colores[indice];
               
                cantp -= cant;
                

                if (cantp <= 0 )
                {

                    a.colores.SetValue(null, indice);

                }
                if (cantp > 0)
                {

                    a.colores[indice] += (sbyte)(cantp * (-1));

                }


            }
            

            return a;

        }



        private int encuentroindice ()
        {
            int retorno = -1;
            for (int i = 0; i < this.cantmaxelementos; i++)
            {
                if (this.colores.GetValue(i) == null)
                {
                    retorno = i;
                        
                }

            }

            return retorno;
        }

        private int encuentroindice( tempera a)
        {
            int retorno = -1;
            for (int i = 0; i < this.cantmaxelementos; i++)
            {
                if (this.colores[i] == a)
                {
                    retorno = i;

                }

            }

            return retorno;
        }

        #endregion


    }
}
