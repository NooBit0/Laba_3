using System;
using System.Linq;

namespace Task1
{
    public static class Input
    {
        public static int[] InputArr(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                }
            }

            return arr;
        }

        public static int[] InputArr(int[] arr1, int[] arr2, int sizeArrA, int sizeNewArr)
        {
            int[] arr = new int[sizeNewArr];
            int tempInt;

            int min1 = Array.IndexOf(arr2, arr2.Min());
            int min2 = Array.IndexOf(arr1, arr1.Min());

            Array.Copy(arr2, min1, arr, 0, arr2.Length - min1);

            Console.WriteLine("Input index");
            while (!int.TryParse(Console.ReadLine(), out tempInt) || (tempInt < 0) || tempInt > arr2.Length || tempInt < min2 || tempInt > sizeArrA)
            {
            }

            Array.Copy(arr1, min2, arr, arr2.Length - min1, tempInt - min2);

            return arr;
        }

        public static int InputSize()
        {
            int size;

            Console.WriteLine("Input size: ");

            while (!int.TryParse(Console.ReadLine(), out size) || size < 0)
            {
            }

            return size;
        }
    }
}
