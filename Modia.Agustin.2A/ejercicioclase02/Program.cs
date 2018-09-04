using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;

namespace ejercicioclase02
{
    class Program
    {
        static void Main(string[] args)
        {
           Sello.mensaje = "";
            Sello.ImprimirEnColor();
            Console.Write(Sello.Imprimir()); 
            Console.ReadLine();
            /*int lenghtmens = Sello.mensaje.Length;
            Console.Write("letras: {0}", lenghtmens);
            Console.ReadLine();
            Sello.Borrar();*/
            Sello.mensaje = "agustin modia";
            Console.Write(Sello.Imprimir());
            Console.ReadLine();

        }
    }
}
