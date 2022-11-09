using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Queue
    {
        int[] elements;
        int front;
        int back;
        int max;
        public Queue(int size)
        {
            elements = new int[size];
            front = 0;
            back = -1;
            max = size;
        }

        public void Enqueue(int item)
        {
            if (back == max - 1)
            {
                Console.WriteLine("Queue is overflow");
            }
            else
            {
                elements[++back] = item;
            }
        }
        public int Dequeue()
        {
            if (front == back + 1)
            {
                Console.WriteLine("Queue is uderflow");
                return -1;
            }
            else
            {
                Console.WriteLine($"Deleted item is: {elements[front]}");
                return elements[front++];
            }

        }
        public void PrintQueue()
        {
            if (front == back + 1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.Write("Queue is: ");
                for (int i = front; i <= back; i++)
                {
                    Console.Write($"{elements[i]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
