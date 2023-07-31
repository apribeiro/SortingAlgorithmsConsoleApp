namespace SortingAlgorithmsConsoleApp
{
    /// <summary>
    /// Represents the interface for sorting strategies.
    /// </summary>
    public interface ISortStrategy
    {
        /// <summary>
        /// Gets the selected sorting strategy name.
        /// </summary>
        /// <returns>The name of the selected sorting strategy.</returns>
        public string StrategyName { get; }

        /// <summary>
        /// Sorts an integer array in ascending order.
        /// </summary>
        /// <param name="array">The integer array to be sorted.</param>
        void Sort(int[] array);
    }
}
