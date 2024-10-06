namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            Console.WriteLine("Unsorted: " + string.Join(' ', array));
            Console.WriteLine("BubbleSort: " + string.Join(' ', BubbleSort(array)));
            Console.WriteLine("===================================================");
            int[] array1 = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = random.Next(100);
            }
            Console.WriteLine("Unsorted: " + string.Join(' ', array1));
            Console.WriteLine("SelectionSort: " + string.Join(' ', SelectionSort(array1)));
            Console.WriteLine("===================================================");
            int[] array2 = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = random.Next(100);
            }
            Console.WriteLine("Unsorted: " + string.Join(' ', array2));
            Console.WriteLine("InsertionSort: " + string.Join(' ', InsertionSort(array2)));
        }

        static int[] InsertionSort(int[] array2)
        {
            for (int i = 0; i < array2.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array2[j - 1] > array2[j])
                    {
                        int temp = array2[j - 1];
                        array2[j - 1] = array2[j];
                        array2[j] = temp;
                    }
                }
            }
            return array2;
        }
        static int[] SelectionSort(int[] array1)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                int min = i;
                for (int j = i; j < array1.Length; j++)
                {
                    if (array1[min] > array1[j])
                    {
                        min = j;
                    }
                }
                int tempVar = array1[min];
                array1[min] = array1[i];
                array1[i] = tempVar;
            }
            return array1;
        }
        static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int swap = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swap;
                    }
                }
            }
            return array;
        }
    }
}
