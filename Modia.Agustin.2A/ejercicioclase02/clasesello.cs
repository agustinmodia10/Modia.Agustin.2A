using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    class Sello
    {
        public static string mensaje;
         
        public static string Imprimir()
        {




            if (Sello.TryParse() == true)
            {

                Sello.ArmarFormatoMensaje();
                Sello.ImprimirEnColor();

            }

            if (Sello.TryParse() == false)
            {
                Console.Write("no hay mensaje que mostrar");
            }


         return Sello.mensaje;

        }
            public static void Borrar()
        {
            Sello.mensaje = "";

        }

        public static ConsoleColor Color = ConsoleColor.Blue;
      
        
        public static void ImprimirEnColor()
        {
            Console.BackgroundColor = Sello.Color;
         

            
           
        }

        private static string ArmarFormatoMensaje()// usar lenth para saber tamaño y agregarle un cuadro de * al mensaje
        {
           

            string acumulador = "";
            int lenghtmens = Sello.mensaje.Length;

            lenghtmens = lenghtmens + 2;

            for (int i = 0; i < lenghtmens; i++)
            {

                acumulador = acumulador + '*';


            }

            acumulador = acumulador + "\n";
            Sello.mensaje = '*' + Sello.mensaje;
            Sello.mensaje = acumulador + Sello.mensaje;
            Sello.mensaje = Sello.mensaje + '*' + "\n";



            Sello.mensaje = Sello.mensaje + (acumulador + "\n");

            return Sello.mensaje;

        }


        private static bool TryParse()// ME DEVUELVE TRUE SI HAY MIN 1 CARACTER Y ME DEVUELVE FALSE SI NO HAY NI UN CARACTER
        {
            bool h = false;
            int lenghtmens = Sello.mensaje.Length;
            if(lenghtmens> 0)
            {
                h = true;

            }

            if (lenghtmens <= 0)
            {
                h = false;

            }

            return h;
        }

       
    }
}
