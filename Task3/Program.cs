using System;
using System.Collections.Generic;

namespace Task3
{
    public class Program
    {
        private static void Show(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        private static void Main()
        {
            int[] array0;

            array0 = FileExtensions.ReadArray();

            Console.WriteLine("Array0: ");
            Show(array0);

            Console.WriteLine($"\n\nTask 1.1| Min: {ArrayExtensions.GetMaxElement(array0)}");
            Console.WriteLine($"Task 1.2| Min: {ArrayExtensions.GetMinElement(array0)}");

            Console.WriteLine($"\nTask 2.1| Min left index: {array0.GetIndexMinLeft()}");
            Console.WriteLine($"Task 2.2| Min right index: {array0.GetIndexMinRight()}");

            Console.WriteLine("\nArrayTask 3:");
            int[] arrayTask3 = array0.CreateNewArr();
            Show(arrayTask3);

            Console.WriteLine("\n\nTask 4| Sum between index:");
            Console.WriteLine(arrayTask3.GetArrSum());

            Console.WriteLine("\nTask 5| Amount of elements between index:");
            Console.WriteLine(arrayTask3.GetArrCount());

            Console.WriteLine("\nTask 6| Midle value of elements between index:");
            Console.WriteLine(arrayTask3.GetMidValue());

            Console.WriteLine("\nTask 7| array1:");
            int[] array1 = array0.SortByDescending();
            Show(array1);

            Console.WriteLine("\n\nTask 8| array2:");
            int[] array2 = array0.SortOrderBy();
            Show(array2);

            Console.WriteLine("\n\nTask 9| Five max element:");
            int[] array3 = array0.CreateNewArray3();
            Show(array3);

            Console.WriteLine("\n\nTask 10| Skip frist 5 elemt, amount remaining:");
            Console.WriteLine(array0.GetSkipFiveElSumLast());

            Console.WriteLine("\nTask 11| Skip frist 3 elemt, remaining amount to the max element:");
            Console.WriteLine(array0.GetSkipThreeElSumLasforMax());

            Console.WriteLine("\nTask 12| Skip frist 3 elemt, remaining amount to the max element:");
            Show(array0.GetFivesElMaxK(10));

            Console.WriteLine("\n\nTask 13| First five min elements");
            int[] array4 = array0.CreateNewArray4();
            Show(array4);

            Console.WriteLine("\n\nTask 14| New arr with elements array3 and array4");
            int[] array5 = array3.MergingArray(array4);
            Show(array5);

            Console.WriteLine("\n\nTask 15| An array that does not contain the elements of an array3");
            int[] array6 = array0.CreateExceptArr(array3);
            Show(array6);

            Console.WriteLine("\n\nTask 16| Various array0 elements");
            int[] array7 = array0.CreateDistinctArray();
            Show(array7);

            Dictionary<int, int> dictionary = array0.CreateDictionary();
            foreach (KeyValuePair<int, int> el in dictionary)
            {
                Console.WriteLine($"Key: {el.Key} - Value: {el.Value}");
            }
        }
    }
}
