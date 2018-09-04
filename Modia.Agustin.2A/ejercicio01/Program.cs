using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int nums = 0;
            int i;
            int max = 0;
            int min = 0;
            int suma = 0;
            float promedio = 0;

            for (i = 0;  i < 5; i++)
            {
                Console.WriteLine("ingrese un numero");
                nums= int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = nums;
                    min = nums;

                }

                if ( nums > max)
                    {
                        max = nums;
                    }

                        if( nums < min)
                    {
                        min = nums;
                    }
                    

                
                suma += nums;

            }
            promedio = (float) suma /  i ;
            Console.WriteLine("numero maximo ingresado es : {0}, el minimo es : {1} y el promedio es : {2:0.00}", max, min, promedio);
            Console.ReadLine();





        }
    }
}
