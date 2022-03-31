using System;

namespace InsertionSort
{
    class Program
    {
        //Space complexity O(1)
        //Time Complexity
        //// best case O(n) if it's already sorted and you just nee iterated them
        ///worst case O(n^2) if it's not sorted and need for loops
        ///
        static void Main(string[] args)
        {
            int[] array = new int[] { 80, 90, 60, 30, 50, 70, 40 };

            int[] insertSortArray = insertionSort(array);
            foreach (var item in insertSortArray)
            {
                Console.Write(item + ",");
            }
        }
        //0  1  2  3  4  5  6
        public static int[] insertionSort(int[] array) // 80 90 60 30 50 70 40
        {
            int key, j;
            for (int i = 1; i < array.Length; i++)
            {
                j = i - 1; //0 //1
                key = array[i]; //90 //60
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key; //90
            }

            return array;
        }
    }
}
