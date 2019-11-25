using System;

namespace Task2
{
    internal class Program
    {
        private static void Main()
        {
            int sizeArr;
            int[,] arr;

            sizeArr = MatrixCreationExtensions.InputSize();
            arr = MatrixCreationExtensions.GenerateMatrix(sizeArr);

            Matrix arrA = new Matrix("A", arr);

            arr = MatrixCreationExtensions.GenerateMatrix(sizeArr);

            Matrix arrB = new Matrix("B", arr);

            Console.WriteLine("Matrix A");
            Console.WriteLine(arrA);

            Console.WriteLine("Matrix B");
            Console.WriteLine(arrB);

            Matrix.CompareLines(arrA, arrB);
        }
    }
}
