namespace Bran.Implementations
{
    interface ISortingAlgorithms
    {
        void BubbleSort(int[] array);
        void QuickSort(int[] array, int left, int rigth);
        void SelectionSort(int[] array);
        void InsertionSort(int[] array);
        void MergeSort(int[] array, int left, int rigth);
    }
}
