using System;

namespace LinearSearch
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

            int[] itemsList =  new int[noOfItems];
            Console.Write("Enter Items: ");
            for (int i = 0; i < noOfItems; i++)
            {
                itemsList[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter Search Item: ");
            int searchItem = Convert.ToInt32(Console.ReadLine());

            int result = LinearSearch(itemsList, searchItem);

            if (result != 0)
            {
                Console.WriteLine($"Item is found in {result+1} times");
            }
            else
            {
                Console.WriteLine("Item does not found");
            }
        }
        static int LinearSearch(int[] itemsList, int searchItem)
        {
            int count = 0;
            for (int i = 0; i < itemsList.Length; i++)
            {
                if (itemsList[i] == searchItem)
                {
                    Console.WriteLine($"{searchItem} is found in {i} index");
                    count++;
                }
            }
            return count;
        }
    }
}
