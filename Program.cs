using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaDeMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 4, 9, 12 }, { 5, 8, 8 }, { 5, 7, 8 } };
            int[,] B = { { 5, 7, 8 }, { 5, 7, 8 }, { 5, 7, 8 } };
            int[,] C = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) C[i, j] = A[i, j] - B[i, j];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(C[i, j] + "\t");

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}