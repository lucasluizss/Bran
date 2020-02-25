namespace Bran.Implementations
{
    interface ISearchAlgorithms
    {
        T BinarySearch<T>(T[] array, int left, int rigth, int target);
        T LinearSearch<T>(T[] array, int target);
    }
}
