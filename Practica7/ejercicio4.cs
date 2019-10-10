using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class ejercicio4
    {
        static void arreglo(int[,] matriz)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz.Length; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] Num;
            Num = new int[3, 3];
            int num = 0;
            for (int i = 0; i < Num.Length; i++)
            {
                for (int j = 0; j < Num.Length; j++)
                {
                    Console.WriteLine("Favor escriba un número:");
                    num = Convert.ToInt32(Console.ReadLine());
                    Num[i, j] = num;
                }
            }
            arreglo(Num);
            Console.ReadKey();
        }
    }
}
