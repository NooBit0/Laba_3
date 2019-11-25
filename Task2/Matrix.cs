using System;
using System.Text;

namespace Task2
{
    public class Matrix
    {
        #region Fields
        private int _columnWithZero;
        private int[] _multiplicationLine;
        #endregion

        #region Constructor
        public Matrix(string nameArr, int[,] arr)
        {
            Name = nameArr;
            Items = arr;
            if (arr.GetLength(0) != arr.GetLength(1))
            {
                throw new ArgumentException("Dimensions of array should be equals.");
            }

            Length = arr.GetLength(0);
            _multiplicationLine = new int[Length];
        }
        #endregion

        #region Properties
        public int Length { get; }

        public int[,] Items { get;  }

        public string Name { get; }
        #endregion

        #region Indexer
        public int this[int i, int j]
        {
            get
            {
                return Items[i, j];
            }

            set
            {
                Items[i, j] = value;
            }
        }
        #endregion

        #region Methods
        public static void CompareLines(Matrix arrA, Matrix arrB)
        {
            if (arrA.CheckColumnToZero() > arrB.CheckColumnToZero())
            {
                arrA.MultiplicationOfRowElements();
                arrA.SwapLine();

                Console.WriteLine($"Matrix {arrA.Name}");
                Console.WriteLine(arrA);
            }
            else if (arrA.CheckColumnToZero() < arrB.CheckColumnToZero())
            {
                arrB.MultiplicationOfRowElements();
                arrB.AddingNonZeroElementsWithRowMultiplication();

                Console.WriteLine($"Matrix {arrB.Name}");
                Console.WriteLine(arrB);
            }
            else
            {
                Console.WriteLine("Columns with zero equally");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    result.Append(Items[i, j]).Append("\t");
                }

                result.Append("\n");
            }

            return result.ToString();
        }

        private void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        private int CheckColumnToZero()
        {
            int count = 0;

            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (Items[j, i] == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count > 0)
                {
                    _columnWithZero++;
                }

                count = 0;
            }

            return _columnWithZero;
        }

        private void MultiplicationOfRowElements()
        {
            for (int i = 0; i < Length; i++)
            {
                _multiplicationLine[i] = 1;

                for (int j = 0; j < Length; j++)
                {
                    _multiplicationLine[i] *= Items[i, j];
                }
            }
        }

        private void AddingNonZeroElementsWithRowMultiplication()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (Items[i, j] != 0)
                    {
                        Items[i, j] += _multiplicationLine[i];
                    }
                }
            }
        }

        private void SwapLine()
        {
            for (int k = 0; k < Length; k++)
            {
                for (int i = 0; i < Length - 1; i++)
                {
                    if (_multiplicationLine[i] < _multiplicationLine[i + 1])
                    {
                        Swap(ref _multiplicationLine[i], ref _multiplicationLine[i + 1]);

                        for (int j = 0; j < Length; j++)
                        {
                            Swap(ref Items[i, j], ref Items[i + 1, j]);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
