using System;

namespace SelectionSort
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
            SelectionSort(itemsList, order);
        }

        static void SelectionSort(int[] itemsList, char order)
        {
            for (int i = 0; i < itemsList.Length-1; i++)
            {
                int minOrMaxIndex = i;
                for(int j = i+1; j < itemsList.Length; j++)
                {
                    if (order == 'a')
                    {
                        if (itemsList[minOrMaxIndex] > itemsList[j])
                        {
                            minOrMaxIndex = j;
                        }
                    }
                    else if(order == 'd')
                    {
                        if (itemsList[minOrMaxIndex] < itemsList[j])
                        {
                            minOrMaxIndex = j;
                        }
                    }
                   
                }
                if(minOrMaxIndex != i)
                {
                    int temp = itemsList[i];
                    itemsList[i] = itemsList[minOrMaxIndex];
                    itemsList[minOrMaxIndex] = temp;
                }
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
