using System;

namespace Task1
{
    internal class Program
    {
        public static void Main()
        {
            int a, b, c;
            int sizeA, sizeB;

            sizeA = Input.InputSize();
            Console.WriteLine("Input array A:");
            CustomArray arrA = new CustomArray("A", Input.InputArr(sizeA));

            sizeB = Input.InputSize();
            Console.WriteLine("Input array B:");
            CustomArray arrB = new CustomArray("B", Input.InputArr(sizeB));

            Console.WriteLine("Input array C:");
            CustomArray arrC = new CustomArray("C", Input.InputArr(arrA.Items, arrB.Items, sizeA, sizeA + sizeB));

            Console.WriteLine(arrA);
            Console.WriteLine(arrB);
            Console.WriteLine(arrC);

            try
            {
                a = arrA.GetNegativeElementsCount();
                b = arrB.GetNegativeElementsCount();
                c = arrC.GetNegativeElementsCount();

                Function.GetValue(a, b, c);
            }
            catch (Exception)
            {
                Console.WriteLine("Value not found!");
            }
        }
    }
}
