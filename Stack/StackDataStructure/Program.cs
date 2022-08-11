using System;

namespace StackDataStructure
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter satck size: ");
            int stackSize = Convert.ToInt32(Console.ReadLine());
            Stack s = new Stack(stackSize);

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Push(6);

            Console.WriteLine("Items are: ");
            s.PrintStack();

            s.Pop();
            s.Pop();
            Console.WriteLine("Items are: ");
            s.PrintStack();
        }
    }

    class Stack
    {
        private int[] elements;
        private int top;
        private int max;
        public Stack(int size)
        {
            elements = new int[size];
            top = -1;
            max = size;
        }

        public void Push(int item)
        {
            if(top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                elements[++top] = item;
            }
        }

        public int Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine($"Poped element is: {elements[top]}");
                return elements[top--];
            }
        }

        public void PrintStack()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine($"Item[{i + 1}]: {elements[i]}");
                }
            }
        }
    }
}
