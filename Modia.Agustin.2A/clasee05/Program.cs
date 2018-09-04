using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasee05
{
    class Program
    {
        static void Main(string[] args)
        {

            bool comparacion;


            tinta mensaje = new tinta();

            Console.WriteLine(tinta.Mostrar(mensaje));

            Console.ReadLine();

            tinta mensaje1 = new tinta( ConsoleColor.Black);

            Console.WriteLine(tinta.Mostrar(mensaje1));

            Console.ReadLine();

            tinta mensaje2 = new tinta(ConsoleColor.Cyan, etipotinta.china);

            Console.WriteLine(tinta.Mostrar(mensaje2));

            Console.ReadLine();

            tinta mensaje3 = new tinta(ConsoleColor.Cyan, etipotinta.china);
          
            comparacion = mensaje2 == mensaje3;

            Console.WriteLine(comparacion);

            Console.ReadLine();

            comparacion = mensaje1 == mensaje3;

            Console.WriteLine(comparacion);

            Console.ReadLine();

            comparacion = mensaje2 != mensaje3;

            Console.WriteLine(comparacion);

            Console.ReadLine();

            comparacion = mensaje1 != mensaje3;

            Console.WriteLine(comparacion);

            Console.ReadLine();

        }
    }
}
