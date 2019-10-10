using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class ejercicio1
    {
        static void Main(string[] args)
        {
            int[] edad;
            int cant, edades, mayores = 0, menores = 0;
            Console.WriteLine("Ingrese la cantidad de personas:");
            cant = Convert.ToInt32(Console.ReadLine());
            edad = new int[cant];
            for (int i = 1; i <= edad.Length; i++)
            {
                Console.WriteLine("Ingrese la edad del individuo {0}", i);
                edades = Convert.ToInt32(Console.ReadLine());
                if (edades >= 18)
                {
                    mayores++;
                }
                else menores++;
            }
            Console.WriteLine("mayores de edad: {0}\nmenores de edad: {1}", mayores, menores);
            Console.ReadKey();
        }
    }
}
