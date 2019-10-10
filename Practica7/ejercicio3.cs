using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
            int grupo, integrantes;
            Console.WriteLine("Favor ingrese la cantidad de grupos o equipos");
            grupo = Convert.ToInt32(Console.ReadLine());
            string[][] equipos;
            equipos = new string[grupo][];
            for (int i = 0; i < equipos.Length; i++)
            {
                Console.WriteLine("Favor ingrese la cantidad de integrantes que conforman el equipo {0}", (i + 1));
                integrantes = Convert.ToInt32(Console.ReadLine());
                equipos[i] = new string[integrantes];
                for (int j = 0; j < equipos[i].Length; j++)
                {
                    Console.WriteLine("Escriba el nombre del integrante #{0} del equipo {1}", (j + 1), (i + 1));
                    equipos[i][j] = Console.ReadLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Informacion general:");
            for (int i = 0; i < equipos.Length; i++)
            {
                Console.WriteLine("Equipo # {0}:", (i + 1));
                for (int j = 0; j < equipos[i].Length; j++)
                {
                    Console.WriteLine(equipos[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
