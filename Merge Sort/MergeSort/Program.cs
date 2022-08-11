using System;

namespace MergeSort
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
            //Console.Write("For ascending order write 'a' or descending order wirte 'd': ");
            //char order = Convert.ToChar(Console.ReadLine());
            MergeSort(itemsList, 0, itemsList.Length-1);
            Output(itemsList);
        }

        static void MergeSort(int[] itemsList, int left, int right)
        {
            if(left >= right)
            {
                return;
            }
            int mid = left + (right - left) / 2;
            MergeSort(itemsList, left, mid);
            MergeSort(itemsList, mid+1, right);
            Merge(itemsList, left, mid, right);
        }

        static void Merge(int[] itemsList, int left, int mid, int right)
        {
            int leftSize = mid - left + 1;
            int rightSize = right - mid;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            int leftIndex, rightIndex, itemListIndex; 

            for (leftIndex = 0; leftIndex < leftSize; leftIndex++)
            {
                leftArray[leftIndex] = itemsList[left+ leftIndex];
            }
            for (rightIndex = 0; rightIndex < rightSize; rightIndex++)
            {
                rightArray[rightIndex] = itemsList[mid+1+rightIndex];
            }
            
            leftIndex = 0;
            rightIndex = 0;
            for (itemListIndex = left; leftIndex < leftSize && rightIndex < rightSize; itemListIndex++)
            {
                if(leftArray[leftIndex] < rightArray[rightIndex])
                {
                    itemsList[itemListIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    itemsList[itemListIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
            }
            while(leftIndex < leftSize)
            {
                itemsList[itemListIndex] = leftArray[leftIndex];
                itemListIndex++;
                leftIndex++;
            }
            while (rightIndex < rightSize)
            {
                itemsList[itemListIndex] = rightArray[rightIndex];
                itemListIndex++;
                rightIndex++;
            }
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
