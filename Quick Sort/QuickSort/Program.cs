using System;

namespace QuickSort
{
    class Program
    {
        static void Main(String[] args)
        {
            Input();
        }

        static void Input()
        {
            Console.Write("Enter Number of Items: ");
            int noOfItems = Convert.ToInt32(Console.ReadLine());

            int[] itemsList = new int[noOfItems];
            Console.Write("Enter Items: ");
            for (int i = 0; i < noOfItems; i++)
            {
                itemsList[i] = Convert.ToInt32(Console.ReadLine());
            }
            QuickSort(itemsList, 0, itemsList.Length - 1);
            Output(itemsList);
        }
        static void QuickSort(int[] itemsList, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int p = Partition(itemsList, left, right);
            QuickSort(itemsList, left, p - 1);
            QuickSort(itemsList, p + 1, right);
        }
        static int Partition(int[] itemsList, int left, int right)
        {
            int pivot = itemsList[right];
            int i = left - 1;
            for (int j = left; j <= right - 1; j++)
            {
                if(itemsList[j] < pivot)
                {
                    i++;
                    Swap(itemsList, i, j);
                }
            }
            Swap(itemsList, i + 1, right);
            return i + 1;
        }

        static void Swap(int[] itemsList, int i, int j)
        {
            int temp = itemsList[i];
            itemsList[i] = itemsList[j];
            itemsList[j] = temp;
        }
        static void Output(int[] itemList)
        {
            Console.Write("After sorting: ");
            for (int i = 0; i < itemList.Length; i++)
            {
                Console.Write($"{itemList[i]}\t");
            }
        }
    }
}
