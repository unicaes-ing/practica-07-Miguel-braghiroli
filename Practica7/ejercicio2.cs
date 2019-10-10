using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class ejercicio2
    {
        static void Main(string[] args)
        {
            int[] numeros;
            int cant, num, par = 0, impar = 0;
            Console.WriteLine("Favor ingrese la cantidad de numeros que desea");
            cant = Convert.ToInt32(Console.ReadLine());
            numeros = new int[cant];
            for (int i = 1; i <= numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un número");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    par++;
                }
                else impar++;
            }
            Console.WriteLine("Numeros pares: {0}\nnumeros impares: {1}", par, impar);
            Console.ReadKey();
        }
    }
}
