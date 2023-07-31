namespace SortingAlgorithmsConsoleApp
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90, 81, 57, 31 };

            Console.WriteLine("Original Array:");
            PrintArray(array);

            Console.WriteLine("\nSelect the sorting algorithm:");
            Console.WriteLine("1. Selection Sort");
            Console.WriteLine("2. Quick Sort");
            Console.WriteLine("3. Merge Sort");
            Console.WriteLine("4. Insertion Sort");
            Console.WriteLine("5. Bubble Sort");
            Console.Write("Enter the number of your choice (1 to 5): ");

            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid input. Please enter a valid choice (1 to 5).");
                Console.Write("Enter the number of your choice: ");
            }

            SortContext context = new SortContext();

            switch (choice)
            {
                case 1:
                    context.SetStrategy(new SelectionSortStrategy());
                    break;
                case 2:
                    context.SetStrategy(new QuickSortStrategy());
                    break;
                case 3:
                    context.SetStrategy(new MergeSortStrategy());
                    break;
                case 4:
                    context.SetStrategy(new InsertionSortStrategy());
                    break;
                case 5:
                    context.SetStrategy(new BubbleSortStrategy());
                    break;
                default:
                    break;
            }

            Console.WriteLine($"\n{context.GetStrategyName()} selected.");
            context.SortArray(array);

            Console.WriteLine("\nSorted Array:");
            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}