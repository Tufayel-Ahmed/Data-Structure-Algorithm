using System;

namespace BubbleSort
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
            Console.Write("For ascending order write 'a' or descending order wirte 'd': ");
            char order = Convert.ToChar(Console.ReadLine());
            BubbleSort(itemsList, order);
        }

        static void BubbleSort(int[] itemList, char order)
        {
            for (int i = 0; i < itemList.Length; i++)
            {
                bool swapped = false;
                for (int j = 0; j < itemList.Length - i - 1; j++)
                {
                    if(order == 'a')
                    {
                        if (itemList[j] > itemList[j + 1])
                        {
                            int temp = itemList[j];
                            itemList[j] = itemList[j + 1];
                            itemList[j + 1] = temp;
                            swapped = true;
                        }
                    }
                    else if (order == 'd')
                    {
                        if (itemList[j] < itemList[j + 1])
                        {
                            int temp = itemList[j];
                            itemList[j] = itemList[j + 1];
                            itemList[j + 1] = temp;
                            swapped |= true;
                        }
                    }
                }
                if(swapped == false)
                {
                    break;
                }
            }
            Output(itemList);
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