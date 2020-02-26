namespace Bran.Implementations
{
    public class SearchAlgorithms : ISearchAlgorithms
    {
        /// <summary>
        /// Binary Search is searching the sorted array by repeatedly dividing the search interval in half.
        /// We can use recursion to implement the algorithm. During each iteration, we take the middle element,
        /// compare it with the searched value, than take the corresponding half and repeat the process.
        /// </summary>
        public int BinarySearch(int[] array, int left, int rigth, int target)
        {
            if (rigth >= left)
            {
                int middle = left + (rigth - left) / 2;

                if (array[middle] == target)
                    return middle;
                if (array[middle] > target)
                    return BinarySearch(array, left, middle - 1, target);
                else
                    return BinarySearch(array, middle + 1, rigth, target);
            }

            return -1;
        }

        /// <summary>
        /// Linear Search is a simple search algorithm, wich checks every element of the array for a match, and returns the index of the matched element. 
        /// The implementation is very simple - we just need one loop to go through the whole array and check for a match.
        /// </summary>
        public int LinearSearch(int[] array, int target)
        {
            for (int index = 0; index < array.Length; index++)
                if (array[index] == target) 
                    return index;

            return -1;
        }
    }
}
