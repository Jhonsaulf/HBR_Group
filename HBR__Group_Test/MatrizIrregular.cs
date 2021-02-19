using System;
using System.Collections.Generic;
using System.Text;

namespace HBR__Group_Test
{
    class MatrizIrregular
    {
        public static int[][] intMatrizIrregular= new int[5][];

        public static void IrregularMatrices()
        {
            intMatrizIrregular[0] = new int[1];
            intMatrizIrregular[1] = new int[2];
            intMatrizIrregular[2] = new int[3];
            intMatrizIrregular[3] = new int[4];
            intMatrizIrregular[4] = new int[5];

            for (int i = 0; i < intMatrizIrregular.GetLength(0); i++)
            {
                Console.WriteLine($"{i} Fila: ");
                for (int e = 0; e < intMatrizIrregular[i].Length; e++)
                {
                    Console.Write("\nInsert a number:");
                    intMatrizIrregular[i][e] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine();
            for (int i = 0; i < intMatrizIrregular.GetLength(0); i++)
            {
                Console.WriteLine($"{i}Row Print");
                for (int e = 0; e < intMatrizIrregular[i].Length; e++)
                {
                    Console.WriteLine("Print columns");

                    Console.WriteLine(intMatrizIrregular[i][e]);
                }

            }

        }
    }
}
