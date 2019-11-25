using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    public static class ArrayExtensions
    {
        public static int GetMaxElement(this int[] arr) => arr.Max();

        public static int GetMinElement(this int[] arr) => arr.Min();

        public static int GetIndexMinLeft(this int[] arr) => arr.Select((item, index) =>
                (item, index)).Where(obj => obj.item == arr.Min()).First().index;

        public static int GetIndexMinRight(this int[] arr) => arr.Select((item, index) => (item, index))
                .Where(obj => obj.index > 5 && obj.item == arr.Min()).Select(obj => obj.index).Last();

        public static int[] CreateNewArr(this int[] arr) => arr.Select((item, index) => (item, index))
                .Where(obj => obj.index > GetIndexMinLeft(arr) && obj.index < GetIndexMinRight(arr)).Select(obj => obj.item).ToArray();

        public static int GetArrSum(this int[] arr) => arr.Sum();

        public static int GetArrCount(this int[] arr) => arr.Count();

        public static int GetMidValue(this int[] arr) => arr.Sum() / arr.Count();

        public static int[] SortByDescending(this int[] arr) => arr.OrderByDescending(item => item).ToArray();

        public static int[] SortOrderBy(this int[] arr) => arr.OrderBy(item => item).ToArray();

        public static int[] CreateNewArray3(this int[] arr) => arr.OrderByDescending(item => item)
                .Select(obj => obj).Take(5).ToArray();

        public static int GetSkipFiveElSumLast(this int[] arr) => arr.Skip(5).Sum();

        public static int GetIndexMaxElement(this int[] arr) => arr.Select((item, index) => (item, index))
                .Where(obj => obj.item == arr.Max()).Select(obj => obj.index).First();

        public static int GetSkipThreeElSumLasforMax(this int[] arr) => arr.Skip(3).Select((item, index) => (item, index))
                .Where(obj => obj.index < GetIndexMaxElement(arr)).Select(obj => obj.item).Sum();

        public static int[] GetFivesElMaxK(this int[] arr, int k) => arr
                .Where(obj => obj == (arr.Max() - k)).Select(obj => obj).Take(5).ToArray();

        public static int[] CreateNewArray4(this int[] arr) => arr.OrderBy(item => item)
                .Select(obj => obj).Take(5).ToArray();

        public static int[] MergingArray(this int[] arr3, int[] arr4) => arr3.Union(arr4).ToArray();

        public static int[] CreateExceptArr(this int[] arr0, int[] arr3) => arr0.Except(arr3).ToArray();

        public static int[] CreateDistinctArray(this int[] arr) => arr.Distinct().ToArray();

        public static Dictionary<int, int> CreateDictionary(this int[] arr) => arr.Distinct()
            .ToDictionary(obj => obj, item => arr.Where(obj => obj == item).Select(obj => obj).Count());
    }
}
