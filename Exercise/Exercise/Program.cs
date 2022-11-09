using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 10, 8, 6, 2, 4, 9, 7, 1, 3, 5 };
            int target = 4;
            int resutlt = LinearSearch(array, target);
            if (resutlt == -1)
            {
                Console.WriteLine("----------Linear Search----------");
                Console.WriteLine($"{target} is not found");
            }
            else
            {
                Console.WriteLine("----------Linear Search----------");
                Console.WriteLine($"{target} is found in index: {resutlt}");
            }

            int[] array2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int target2 = 10;
            int resutlt2 = BinarySearch(array2, target2);
            if (resutlt2 == -1)
            {
                Console.WriteLine("----------Binary Search----------");
                Console.WriteLine($"{target2} is not found");
            }
            else
            {
                Console.WriteLine("----------Binary Search----------");
                Console.WriteLine($"{target2} is found in index: {resutlt2}");
            }
        }

        public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {

                    return i;
                }
            }
            return -1;
        }

        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if(array[mid] == target)
                {
                    return mid;
                }
                if(array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
