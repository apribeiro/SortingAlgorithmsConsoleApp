namespace SortingAlgorithmsConsoleApp
{
    /// <summary>
    /// Implements the Bubble Sort algorithm as a sorting strategy.
    /// </summary>
    public class BubbleSortStrategy : ISortStrategy
    {
        /// <inheritdoc/>
        public string StrategyName => "Bubble Sort";

        /// <inheritdoc/>
        public void Sort(int[] array)
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    // If the current element is greater than the next element, swap them
                    if (array[j] > array[j + 1])
                    {
                        this.Swap(array, j, j + 1);
                        swapped = true;
                    }
                }

                // If no two elements were swapped in the inner loop, the array is already sorted
                if (!swapped)
                {
                    break;
                }
            }
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
