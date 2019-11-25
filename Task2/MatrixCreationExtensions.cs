using System;

namespace Task2
{
    public static class MatrixCreationExtensions
    {
        public static int[,] GenerateMatrix(int sizeArr)
        {
            int[,] arr = new int[sizeArr, sizeArr];

            Random ran = new Random();

            for (int i = 0; i < sizeArr; i++)
            {
                for (int j = 0; j < sizeArr; j++)
                {
                    arr[i, j] = ran.Next(-10, 10);
                }
            }

            return arr;
        }

        public static int InputSize()
        {
            int sizeArr;

            Console.WriteLine("Input size arr:");

            while (!int.TryParse(Console.ReadLine(), out sizeArr) || sizeArr < 2)
            {
            }

            return sizeArr;
        }
    }
}
