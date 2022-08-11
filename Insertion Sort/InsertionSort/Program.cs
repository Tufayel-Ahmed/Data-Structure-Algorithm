using System;

namespace InsertionSort
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
            Console.Write("For ascending order write 'a' or descending order write 'd': ");
            char order = Convert.ToChar(Console.ReadLine());
            InsertionSort(itemsList, order);
        }

        static void InsertionSort(int[] itemsList, char order)
        {
            for (int i = 1; i < itemsList.Length; i++)
            {
                int item = itemsList[i];
                int j = i - 1;
                if (order == 'a')
                {
                    while (j >= 0 && itemsList[j] > item)
                    {
                        itemsList[j + 1] = itemsList[j];
                        j--;
                    }
                }
                else if (order == 'd')
                {
                    while (j >= 0 && itemsList[j] < item)
                    {
                        itemsList[j + 1] = itemsList[j];
                        j--;
                    }
                }               
                itemsList[j+1] = item;
            }
            Output(itemsList);
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