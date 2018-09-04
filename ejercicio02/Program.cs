using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            double num;
            double cubo = 0;
            double cuadrado = 0;

            Console.WriteLine("ingrese un numero");
            num = int.Parse(Console.ReadLine());

            while(num <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!: ");
                num = int.Parse(Console.ReadLine());

            }

            cuadrado = Math.Pow(num, 2);
            cubo = Math.Pow(num, 3);

            Console.WriteLine("el cuadradro de {0} es: {1} y el cubo de {0} es : {2}" ,num, cuadrado, cubo);
        }
    }
}
