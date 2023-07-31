namespace SortingAlgorithmsConsoleApp
{
    /// <summary>
    /// Implements the Quick Sort algorithm as a sorting strategy.
    /// </summary>
    public class QuickSortStrategy : ISortStrategy
    {
        /// <inheritdoc/>
        public string StrategyName => "Quick Sort";

        /// <inheritdoc/>
        public void Sort(int[] array)
        {
            this.QuickSort(array, 0, array.Length - 1);
        }

        private void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = this.Partition(array, low, high);

                this.QuickSort(array, low, partitionIndex - 1);
                this.QuickSort(array, partitionIndex + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    this.Swap(array, i, j);
                }
            }

            this.Swap(array, i + 1, high);

            return i + 1;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
