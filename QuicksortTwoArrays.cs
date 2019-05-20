namespace SortingIntegers
{
    /*
        Description.
        Modified quicksort algorithm that takes two arrays as input and
        treats them as one. It sorts the arrays inplace without combining them in memory.

        Efficiency notes.
        The algorithm can be made more efficient by using the randomized version
        of Quicksort.

        Example.
        Input [4, 6, 1] [2, 3, 9]
        Output [1, 2, 3] [4, 6, 9]

        Testing.
        To test this algorithm, call SortArrays function with 2 arrays as input.
    */
    public class QuicksortTwoArrays {

        public static void SortArrays(int[] arrA, int[] arrB)
        {
            int maxIndex = arrA.Length + arrB.Length - 1;

            QuicksortArray(arrA, arrB, 0, maxIndex);
        }

        private static void QuicksortArray(int[] arrA, int[] arrB, int start, int end)
        {
            if (start < end)
            {
                // Partition array
                int partitionIndex = Partition(arrA, arrB, start, end);

                // Quicksort left partition
                QuicksortArray(arrA, arrB, start, partitionIndex - 1);

                // Quicksort right partition
                QuicksortArray(arrA, arrB, partitionIndex + 1, end);
            }
        }

        private static int Partition(int[] arrA, int[] arrB, int start, int end)
        {
            int pivot = TwoArrayOperations.GetValue(arrA, arrB, end);

            int partitionIndex = start;

            for (int i = start; i < end; i++)
            {

                if (TwoArrayOperations.GetValue(arrA, arrB, i) <= pivot)
                {
                    TwoArrayOperations.Swap(arrA, arrB, partitionIndex, i);
                    partitionIndex++;
                }

            }

            TwoArrayOperations.Swap(arrA, arrB, partitionIndex, end);
            return partitionIndex;
        }

    }

    /*
        Each public method in this class takes two arrays as input and
        treats them as a combined single array, without actually combining them in memory.
        This allows to go out of first array's bounds, the indices will simply be translated
        onto the second array.
    */
    internal class TwoArrayOperations {

        public static void Swap(int[] arrA, int[] arrB, int iOne, int iTwo)
        {
            int tempOne = GetValue(arrA, arrB, iOne);
            int tempTwo = GetValue(arrA, arrB, iTwo);

            PutValue(arrA, arrB, iOne, tempTwo);
            PutValue(arrA, arrB, iTwo, tempOne);
        }

        public static int GetValue(int[] arrA, int[] arrB, int index)
        {
            int maxIndexA = arrA.Length - 1;

            if (index <= maxIndexA)
            {
                return arrA[index];
            }
            else
            {
                return arrB[index - maxIndexA - 1];
            }
        }

        public static void PutValue(int[] arrA, int[] arrB, int index, int value)
        {
            int maxIndexA = arrA.Length - 1;

            if (index <= maxIndexA)
            {
                arrA[index] = value;
            }
            else
            {
                arrB[index - maxIndexA - 1] = value;
            }
        }

    }
}
