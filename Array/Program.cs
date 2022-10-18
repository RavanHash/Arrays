namespace Array
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = GetIntegerFromConsole();

            // 1. Console.WriteLine(FindMin(CreatArray(n)));
            // 2. Console.WriteLine(FindMax(CreatArray(n)));
            // 3. Console.WriteLine(FindMinIndex(CreatArray(n)));
            // 4. Console.WriteLine(FindMaxIndex(CreatArray(n)));
            // 5. Console.WriteLine(ArraySumWithOddIndex(CreatArray(n)));
            // 6. OutputArray(MirrorArray(CreatArray(n)));
            // 8. OutputArray(MirrorHalfArray(CreatArray(n)));
            // 9. OutputArray(SelectionShort(CreatArray(n)));
            // 10. OutputArray(QuickSort(CreatArray(n), 0, n - 1));
        }

        private static int GetIntegerFromConsole()
        {
            int number;

            Console.Write("Enter integer number: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
            }

            return number;
        }

        private static double GetDoubleFromConsole()
        {
            double number;

            Console.Write("Enter integer number: ");

            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
            }

            return number;
        }

        private static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;
            rightItem = temp;
        }

        private static int[] CreatArray(int arrayCapacity)
        {
            int[] a = new int[arrayCapacity];

            for (int i = 0; i < arrayCapacity; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            return a;
        }

        private static int[] CreatRandomArray(int arrayCapacity)
        {
            int[] a = new int[arrayCapacity];

            for (int i = 0; i < arrayCapacity; i++)
            {
                a[i] = new Random().Next(-100, 100);
            }

            return a;
        }

        private static void OutputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        // 1. Найти минимальный элемент массива.
        private static int FindMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            return min;
        }

        // 2. Найти максимальный элемент массива.
        private static int FindMax(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }

        // 3. Найти индекс минимального элемента массива.
        private static int FindMinIndex(int[] arr)
        {
            int min = arr[0];
            int minIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        // 4. Найти индекс максимального элемента массива.
        private static int FindMaxIndex(int[] arr)
        {
            int max = arr[0];
            int maxIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        // 5. Посчитать сумму элементов массива с нечетными индексами.
        private static int ArraySumWithOddIndex(int[] arr)
        {
            int sum = 0;

            for (int i = 1; i < arr.Length; i += 2)
            {
                sum += arr[i];
            }

            return sum;
        }

        // 6. Сделать реверс массива (массив в обратном направлении).
        private static int[] MirrorArray(int[] arr)
        {
            int len = arr.Length;

            for (int i = 0; i < len / 2; i++)
            {
                int temp = arr[len - i - 1];
                arr[len - i - 1] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }

        // 8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        private static int[] MirrorHalfArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[arr.Length / 2 + i];
                arr[arr.Length / 2 + i] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }

        // 9. Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором (Select) или вставками (Insert)).
        private static int[] SelectionShort(int [] arr)
        {
            int temp, smallest;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }

                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }

        // 10. Sort array with quick-sort, timsort, shell-sort, mergesort. https://www.youtube.com/watch?v=eqo2LxRADhU  https://www.youtube.com/watch?v=DmFXdwy_mH0
        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
                return array;

            int pivotIndex = GetPivotIndex(array,minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivotInsex = minIndex - 1;
            int pivotValue = array[maxIndex];

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < pivotValue)
                {
                    pivotInsex++;
                    Swap(ref array[pivotInsex], ref array[i]);
                } 

            }

            pivotInsex++;
            Swap(ref array[pivotInsex], ref array[maxIndex]);

            return pivotInsex;
        }
    }
}