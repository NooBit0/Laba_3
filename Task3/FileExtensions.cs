using System.IO;
using System.Linq;

namespace Task3
{
    public static class FileExtensions
    {
        public static int[] ReadArray()
        {
            string[] tempArr;

            tempArr = File.ReadAllLines(@"..\..\..\arr.txt");

            return tempArr.Select(x => int.Parse(x)).ToArray();
        }
    }
}
