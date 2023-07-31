namespace SortingAlgorithmsConsoleApp
{
    /// <summary>
    /// Context class that uses a sorting strategy to sort an array.
    /// </summary>
    public class SortContext
    {
        private ISortStrategy strategy;

        /// <summary>
        /// Sets the sorting strategy to be used.
        /// </summary>
        /// <param name="strategy">The sorting strategy to be used.</param>
        public void SetStrategy(ISortStrategy strategy)
        {
            this.strategy = strategy;
        }

        /// <summary>
        /// Gets the selected sorting strategy name.
        /// </summary>
        /// <returns>The name of the selected sorting strategy.</returns>
        public string GetStrategyName()
        {
            return this.strategy.StrategyName;
        }

        /// <summary>
        /// Sorts the given array using the selected sorting strategy.
        /// </summary>
        /// <param name="array">The integer array to be sorted.</param>
        public void SortArray(int[] array)
        {
            this.strategy.Sort(array);
        }
    }
}
