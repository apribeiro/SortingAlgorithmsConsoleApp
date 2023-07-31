namespace SortingAlgorithmsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90, 81, 57, 31 };

            Console.WriteLine("Original Array:");
            PrintArray(array);

            Console.WriteLine("\nSelect the sorting algorithm:");
            Console.WriteLine("1. Selection Sort");
            Console.WriteLine("2. Quick Sort");
            Console.WriteLine("3. Merge Sort");
            Console.WriteLine("4. Insertion Sort");
            Console.Write("Enter the number of your choice (1 to 4): ");

            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a valid choice (1 to 4).");
                Console.Write("Enter the number of your choice: ");
            }

            switch (choice)
            {
                case 1:
                    SelectionSort(array);
                    break;
                case 2:
                    QuickSort(array, 0, array.Length - 1);
                    break;
                case 3:
                    MergeSort(array, 0, array.Length - 1);
                    break;
                case 4:
                    InsertionSort(array);
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nSorted Array:");
            PrintArray(array);
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the element at position i
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);

                QuickSort(arr, low, partitionIndex - 1);
                QuickSort(arr, partitionIndex + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);

            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void MergeSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSort(arr, low, mid);
                MergeSort(arr, mid + 1, high);
                Merge(arr, low, mid, high);
            }
        }

        static void Merge(int[] arr, int low, int mid, int high)
        {
            int leftLength = mid - low + 1;
            int rightLength = high - mid;

            int[] leftArray = new int[leftLength];
            int[] rightArray = new int[rightLength];

            for (int i = 0; i < leftLength; i++)
            {
                leftArray[i] = arr[low + i];
            }

            for (int j = 0; j < rightLength; j++)
            {
                rightArray[j] = arr[mid + 1 + j];
            }

            int leftIndex = 0;
            int rightIndex = 0;
            int mergeIndex = low;

            while (leftIndex < leftLength && rightIndex < rightLength)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    arr[mergeIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[mergeIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                mergeIndex++;
            }

            while (leftIndex < leftLength)
            {
                arr[mergeIndex] = leftArray[leftIndex];
                leftIndex++;
                mergeIndex++;
            }

            while (rightIndex < rightLength)
            {
                arr[mergeIndex] = rightArray[rightIndex];
                rightIndex++;
                mergeIndex++;
            }
        }

        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}