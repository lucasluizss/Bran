namespace Bran.Implementations
{
    interface ISortingAlgorithms
    {
        void BubbleSort<T>(T[] array);
        void QuickSort<T>(T[] array, int left, int rigth);
        void SelectionSort<T>(T[] array);
        void InsertionSort<T>(T[] array);
        void MergeSort<T>(T[] array);
    }
}
