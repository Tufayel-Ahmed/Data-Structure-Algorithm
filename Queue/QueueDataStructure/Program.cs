using System;

namespace StackDataStructure
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter queue size: ");
            int queueSize = Convert.ToInt32(Console.ReadLine());
            Queue q = new Queue(queueSize);

            q.insert(10);
            q.insert(20);
            q.insert(30);
            q.insert(40);
            q.insert(50);
            q.insert(60);

            Console.WriteLine("Items are: ");
            q.PrintQueue();

            q.delete();
            q.delete();

            Console.WriteLine("After two items delete: ");
            q.PrintQueue();

        }
    }
    class Queue
    {
        private int[] elements;
        private int front;
        private int back;
        private int max;
        public Queue(int size)
        {
            elements = new int[size];
            front = 0;
            back = -1;
            max = size;
        }
        public void insert(int item)
        {
            if(back == max - 1)
            {
                Console.WriteLine("Queue is overflow");
                return;
            }
            else
            {
                elements[++back] = item;
            }
        }

        public int delete()
        {
            if(front == back + 1)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                Console.WriteLine($"Deleted item: {elements[front]}");
                return elements[front++];
            }
        }
        public void PrintQueue()
        {
            if(front == back + 1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                for (int i = front; i <= back; i++)
                {
                    Console.WriteLine($"Item[{i+1}]: {elements[i]}");
                }
            }
        }
    }
}