namespace SortingAlgorithmsConsoleApp
{
    /// <summary>
    /// Implements the Insertion Sort algorithm as a sorting strategy.
    /// </summary>
    public class InsertionSortStrategy : ISortStrategy
    {
        /// <inheritdoc/>
        public string StrategyName => "Insertion Sort";

        /// <inheritdoc/>
        public void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }
    }
}
