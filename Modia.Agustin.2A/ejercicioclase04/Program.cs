using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioclase04
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime fecha = new DateTime (2015, 5, 15);
            DateTime fecha1 = new DateTime(2017, 7, 17);
            cosa datos1 = new cosa();
            datos1.cadena = "hola";
            datos1.numero = 10;
            datos1.fecha = DateTime.Now;
           
            Console.Write(cosa.Mostrar(datos1));
            Console.ReadLine();
            cosa datos2 = new cosa();
            Console.Write(cosa.Mostrar(datos2));
            Console.ReadLine();


            cosa datos3 = new cosa();
            datos3.cadena = "hello";
            Console.Write(cosa.Mostrar(datos3));
            Console.ReadLine();


            cosa datos4 = new cosa();
            datos4.cadena = "hello word";
            datos4.numero = 100;
            Console.Write(cosa.Mostrar(datos4));
            Console.ReadLine();

            cosa datos5 = new cosa();
            datos5.cadena = "hola mundo";
            datos5.numero = 1000;
            datos5.fecha = fecha;
            Console.Write(cosa.Mostrar(datos5));
            Console.ReadLine();


            cosa datos6 = new cosa();
            datos6.EstablecerValor("hola gente");
            datos6.numero = 1000;
            datos6.fecha = fecha;
            Console.Write(cosa.Mostrar(datos6));
            Console.ReadLine();


            cosa datos7 = new cosa();
            datos7.EstablecerValor("hola gente", 1010);
            datos6.fecha = fecha;
            Console.Write(cosa.Mostrar(datos7));
            Console.ReadLine();

            cosa datos8 = new cosa();
            datos8.EstablecerValor("hola gente", 1010, fecha1);
            
            Console.Write(cosa.Mostrar(datos8));
            Console.ReadLine();


        }
    }
}
