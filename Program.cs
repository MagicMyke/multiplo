using System;

namespace Multiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, b, multi;

            multi = 0;

            for (b = 1; b <= 5; b++)
            {
                 Console.WriteLine("Ingrese un numero entero:");
                 valor = int.Parse(Console.ReadLine());
                 if (valor % multi == 0)
                 {
                     multi = multi + 1;
                 } 
                 Console.Write("Los multiplos del numero ingresado son: ");
                 Console.Write(multi);

                 Console.ReadKey();

            }


        }
    }
}
