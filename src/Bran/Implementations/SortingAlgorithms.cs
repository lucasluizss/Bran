using System;

namespace Bran.Implementations
{
    public class SortingAlgorithms : ISortingAlgorithms
    {
        /// <summary>
        /// Bubble sort is used to sort a list of elements, by comparing two adjacent elements and swapping them,
        /// if they are not in order
        /// </summary>
        public void BubbleSort(int[] array)
        {
            bool swapped;

            for (int indexOne = 0; indexOne < array.Length - 1; indexOne++)
            {
                swapped = false;

                for (int indexTwo = 0; indexTwo < array.Length - indexOne - 1; indexTwo++)
                {
                    if (array[indexTwo] > array[indexTwo + 1])
                    {
                        int temp = array[indexTwo];
                        array[indexTwo] = array[indexTwo + 1];
                        array[indexTwo + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped) break;
            }
        }

        /// <summary>
        /// Insertion sort is used to sort a list of elements by taking each element and inserting it in the corresponding position the left
        /// </summary>
        public void InsertionSort(int[] array)
        {
            int indexTwo;

            for (int indexOne = 0; indexOne < array.Length; indexOne++)
            {
                indexTwo = indexOne;

                while (indexTwo > 0 && array[indexTwo - 1] > array[indexTwo])
                {
                    int temp = array[indexTwo];
                    array[indexTwo] = array[indexTwo - 1];
                    array[indexTwo - 1] = temp;
                    indexTwo--;
                }
            }
        }

        /// <summary>
        /// Merge Sort is dividing the array in half over and over again until each piece is only one item long.
        /// Then those items are put back together (merged) in sort-oder.
        /// We will need a Merge funcion, to merge the two halves into a sorted data.
        /// </summary>
        /// 
        private void Merge(int[] array, int left, int merge, int rigth)
        {
            int n1 = merge - left + 1;
            int n2 = rigth - merge;

            int[] Left = new int[n1];
            int[] Rigth = new int[n2];

            for (int x = 0; x < n1; x++)
                Left[x] = array[left + x];
            for (int y = 0; y < n2; y++)
                Rigth[y] = array[merge + 1 + y];

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (Left[i] <= Rigth[j])
                {
                    array[k] = Left[i];
                    i++;
                }
                else
                {
                    array[k] = Rigth[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                array[k] = Left[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = Rigth[j];
                j++;
                k++;
            }
        }

        public void MergeSort(int[] array, int left, int rigth)
        {
            if (left < rigth)
            {
                int merge = (left + rigth) / 2;
                MergeSort(array, left, merge);
                MergeSort(array, merge + 1, rigth);
                Merge(array, left, merge, rigth);
            }
        }

        /// <summary>
        /// QuickSort picks an element as the pivot and partitions the given array around it.
        /// We will choose our pivot randomly.
        /// We will implement the QuickSort function recursively. 
        /// During each iteration out function will pick a random pivot and partition the array base on it.
        /// </summary>
        public void QuickSort(int[] array, int left, int rigth)
        {
            int l = left;
            int r = rigth - 1;
            int size = rigth - left;

            if (size > 1)
            {
                var random = new Random();
                int pivot = array[random.Next(0, size) + l];

                while (l < r)
                {
                    while (array[r] > pivot && r > l)
                        r++;
                    while (array[l] < pivot && l <= r)
                        l++;

                    if (l < r)
                    {
                        int temp = array[l];
                        array[l] = array[r];
                        array[r] = temp;
                        l++;
                    }
                }

                QuickSort(array, left, l);
                QuickSort(array, r, rigth);
            }
        }

        /// <summary>
        /// Selection sort is used to sort a list of elements.
        /// During each iteration the algorithm is taking the smallest element and swaps it with the element in the corresponding position to the left.
        /// </summary>
        public void SelectionSort(int[] array)
        {
            for (int k = 0; k < array.Length - 1; k++)
            {
                int lowestIndex = k;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] < array[lowestIndex])
                        lowestIndex = j;
                }

                int temp = array[lowestIndex];
                array[lowestIndex] = array[k];
                array[k] = temp;
            }
        }
    }
}
