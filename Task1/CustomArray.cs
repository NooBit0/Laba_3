using System;
using System.Collections;

namespace Task1
{
    public class CustomArray
    {
        #region Constructor
        public CustomArray(string nameArr, int[] arr)
        {
            Items = arr;
            Lenth = arr.Length;
            Name = nameArr;
        }
        #endregion

        #region Properties
        public int[] Items { get; }

        public string Name { get; }

        public int Lenth { get; }
        #endregion

        #region Indexer
        public int this[int i]
        {
            get
            {
                return Items[i];
            }

            set
            {
                Items[i] = value;
            }
        }
        #endregion

        #region Metods

        // The number of negative elements after the first zero
        public int GetNegativeElementsCount()
        {
            int[] tempArr = new int[Lenth];

            int tempIndex = Array.IndexOf(Items, Array.Find(Items, i => i == 0));

            if (tempIndex < 0)
            {
                return 0;
            }

            Array.Copy(Items, tempIndex, tempArr, 0, Items.Length - tempIndex);

            return Array.FindAll(tempArr, a => a < 0).Length;
        }

        public override string ToString()
        {
            return string.Join(", ", Items);
        }
        #endregion
    }
}