using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 10, 8, 6, 2, 4, 9, 7, 1, 3, 5};
            int target = 4;
            int resutlt = LinearSearch(array, target);
            if (resutlt == -1)
            {
                Console.WriteLine("Number is not found");
            }
            else
            {
                Console.WriteLine($"Number is found in index: {resutlt}");
            }
        }

        public static int LinearSearch(int[] array, int target)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
