using System;

// ReSharper disable InconsistentNaming
namespace BubbleSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with bubble sort algorithm.
        /// </summary>
        public static void BubbleSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), $"{nameof(array)} is null");
            }

            if (array == Array.Empty<int>())
            {
                throw new ArgumentException($"{nameof(array)} is empty.", nameof(array));
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive bubble sort algorithm.
        /// </summary>
        public static void RecursiveBubbleSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), $"{nameof(array)} is null");
            }

            if (array == Array.Empty<int>())
            {
                throw new ArgumentException($"{nameof(array)} is empty.", nameof(array));
            }

            BubbleSort(array, array.Length);
        }

        private static void BubbleSort(int[] array, int n)
        {
            if (n == 1)
            {
                return;
            }

            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    continue;
                }

                Swap(ref array[i], ref array[i + 1]);
                count++;
            }

            if (count == 0)
            {
                return;
            }

            BubbleSort(array, n - 1);
        }
    }
}
