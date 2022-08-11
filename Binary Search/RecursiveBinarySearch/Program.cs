using System;

namespace RecursiveBinarySearch
{
    class Program
    {
        public static void Main(String[] args)
        {
            Input();
        }
        public static void Input()
        {
            Console.Write("Enter the number of items: ");
            int numberOfItems = Convert.ToInt32(Console.ReadLine());

            int[] itemsList = new int[numberOfItems];
            Console.WriteLine("Enter the items: ");
            for (int i = 0; i < itemsList.Length; i++)
            {
                itemsList[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the searching item: ");
            int searchItem = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            if(itemsList.Length == 0)
            {
                Console.WriteLine("Item list is empty.");
            }
            else
            {
                if (itemsList[0] < itemsList[itemsList.Length - 1])
                {
                    result = AscendingRBinarySearch(itemsList, searchItem, 0, itemsList.Length - 1);
                }
                else
                {
                    result = DescendingRBinarySearch(itemsList, searchItem, 0, itemsList.Length - 1);
                }

                if (result == -1)
                {
                    Console.WriteLine("Item does not find");
                }
                else
                {
                    Console.WriteLine($"Item is found in {result + 1} position");
                }
            }
        }

        // Ascending order
        public static int AscendingRBinarySearch(int[] itemsList, int searchItem, int left, int right)
        {
            if (left <= right)
            {
                int mid = (right + left) / 2;
                if (itemsList[mid] == searchItem)
                {
                    return mid;
                }
                if (itemsList[mid] > searchItem)
                {
                    return AscendingRBinarySearch(itemsList, searchItem, left, mid - 1);
                }
                else
                {
                    return AscendingRBinarySearch(itemsList, searchItem, mid + 1, right);
                }
            }
            return -1;
        }
        public static int DescendingRBinarySearch(int[] itemsList, int searchItem, int left, int right)
        {
            if (left <= right)
            {
                int mid = (right + left) / 2;
                if (itemsList[mid] == searchItem)
                {
                    return mid;
                }
                if (itemsList[mid] > searchItem)
                {
                    return DescendingRBinarySearch(itemsList, searchItem, mid + 1, right);
                }
                else
                {
                    return DescendingRBinarySearch(itemsList, searchItem, left, mid - 1);
                }
            }
            return -1;
        }
    }
}

