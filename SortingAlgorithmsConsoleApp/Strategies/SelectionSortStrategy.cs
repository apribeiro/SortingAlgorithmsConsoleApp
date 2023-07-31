namespace SortingAlgorithmsConsoleApp
{
    /// <summary>
    /// Implements the Selection Sort algorithm as a sorting strategy.
    /// </summary>
    public class SelectionSortStrategy : ISortStrategy
    {
        /// <inheritdoc/>
        public string StrategyName => "Selection Sort";

        /// <inheritdoc/>
        public void Sort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the element at position i
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}
