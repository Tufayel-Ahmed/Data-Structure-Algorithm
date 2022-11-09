﻿using System;
using System.Globalization;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------Linear Search----------
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

            //----------Binary Search----------
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

            //----------Bubble Sort----------
            int[] resutlt3 = BubbleSort(array);
            Console.WriteLine("----------Bubble Sort----------");
            Console.WriteLine(string.Join(", ", resutlt3));

            //----------Selection Sort----------
            int[] resutlt4 = SelectionSort(array);
            Console.WriteLine("----------Selection Sort----------");
            Console.WriteLine(string.Join(", ", resutlt4));

            //----------Insertion Sort----------
            int[] resutlt5 = InsertionSort(array);
            Console.WriteLine("----------Insertion Sort----------");
            Console.WriteLine(string.Join(", ", resutlt5));

            //----------Merge Sort----------
            MergeSort(array, 0, array.Length - 1);
            Console.WriteLine("----------Merge Sort----------");
            Console.WriteLine(string.Join(", ", array));

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

        public static int[] BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length - 1 -i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public static int[] SelectionSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if(i != minIndex)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            int i, j, item;
            for(i = 1; i < array.Length; i++)
            {
                item = array[i];
                j = i - 1;
                while(j >= 0 && array[j] > item)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = item;
            }
            return array;
        }

        public static void MergeSort(int[] array, int left, int right)
        {
            if(left >= right)
            {
                return;
            }
            int mid = left + (right - left) / 2;

            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
        public static void Merge(int[] array, int left, int mid, int right)
        {
            int leftArraySize = mid - left + 1;
            int rightArraySize = right - mid;

            int[] leftArray = new int[leftArraySize];
            int[] rightArray = new int[rightArraySize];

            for(int i = 0; i < leftArraySize; i++)
            {
                leftArray[i] = array[left + i];
            }
            for (int i = 0; i < rightArraySize; i++)
            {
                rightArray[i] = array[mid + 1 + i];
            }
            int arrayIndex;
            int leftIndex = 0;
            int rightIndex = 0;

            for(arrayIndex = left; leftIndex < leftArraySize && rightIndex < rightArraySize; arrayIndex++)
            {
                if(leftArray[leftIndex] < rightArray[rightIndex])
                {
                    array[arrayIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[arrayIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
            }
            while(leftIndex < leftArraySize)
            {
                array[arrayIndex] = leftArray[leftIndex];
                arrayIndex++;
                leftIndex++;
            }
            while(rightIndex < rightArraySize)
            {
                array[arrayIndex] = rightArray[rightIndex];
                arrayIndex++;
                rightIndex++;
            }
        }
    }
}
