namespace SortingAlgorithmsConsoleApp
{
    /// <summary>
    /// Implements the Merge Sort algorithm as a sorting strategy.
    /// </summary>
    public class MergeSortStrategy : ISortStrategy
    {
        /// <inheritdoc/>
        public string StrategyName => "Merge Sort";

        /// <inheritdoc/>
        public void Sort(int[] array)
        {
            this.MergeSort(array, 0, array.Length - 1);
        }

        private void MergeSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                this.MergeSort(array, low, mid);
                this.MergeSort(array, mid + 1, high);
                this.Merge(array, low, mid, high);
            }
        }

        private void Merge(int[] array, int low, int mid, int high)
        {
            int leftLength = mid - low + 1;
            int rightLength = high - mid;

            int[] leftArray = new int[leftLength];
            int[] rightArray = new int[rightLength];

            for (int i = 0; i < leftLength; i++)
            {
                leftArray[i] = array[low + i];
            }

            for (int j = 0; j < rightLength; j++)
            {
                rightArray[j] = array[mid + 1 + j];
            }

            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = low;

            while (leftIndex < leftLength && rightIndex < rightLength)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    array[mergeIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[mergeIndex] = rightArray[rightIndex];
                    rightIndex++;
                }

                mergeIndex++;
            }

            while (leftIndex < leftLength)
            {
                array[mergeIndex] = leftArray[leftIndex];
                leftIndex++;
                mergeIndex++;
            }

            while (rightIndex < rightLength)
            {
                array[mergeIndex] = rightArray[rightIndex];
                rightIndex++;
                mergeIndex++;
            }
        }
    }
}
