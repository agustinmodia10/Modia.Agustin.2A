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

		    Console.WriteLine("PRUEBA PLUMA");
		    pluma plum = new pluma(100, "plumas", mensaje3);
		    pluma plum1 = new pluma(80, "plumas", mensaje3);
		    Console.WriteLine(plum);
		    Console.ReadLine();

		 plum -= mensaje3;
		 Console.WriteLine(plum);
		 Console.ReadLine();

		 plum += mensaje3;
		 Console.WriteLine(plum);
		 Console.ReadLine();

		 plum1 += mensaje3;
		 Console.WriteLine(plum1);
		 Console.ReadLine();

		 pluma plum2 = new pluma(2);

		 Console.WriteLine(plum2);
		 Console.ReadLine();


        }
    }
}
