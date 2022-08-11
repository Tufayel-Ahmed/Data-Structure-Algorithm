using System;

namespace BinarySearch
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

            if (itemsList.Length == 0)
            {
                Console.WriteLine("Item list is empty.");
            }
            else
            {
                if (itemsList[0] < itemsList[itemsList.Length - 1])
                {
                    result = AscendingIterativeBinarySearch(itemsList, searchItem);
                }
                else
                {
                    result = DescendingIterativeBinarySearch(itemsList, searchItem);
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

        public static int AscendingIterativeBinarySearch(int[] itemsList, int searchItem)
        {
            int left = 0;
            int right = itemsList.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (itemsList[mid] == searchItem)
                {
                    return mid;
                }
                else if(itemsList[mid] < searchItem)
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
        public static int DescendingIterativeBinarySearch(int[] itemsList, int searchItem)
        {
            int left = 0;
            int right = itemsList.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (itemsList[mid] == searchItem)
                {
                    return mid;
                }
                else if (itemsList[mid] < searchItem)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
