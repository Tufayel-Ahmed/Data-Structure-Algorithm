using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Stack
    {
        int[] elements;
        int top;
        int max;
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
                Console.WriteLine("Stack is overflow");
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
                Console.WriteLine("Stack is underflow");
                return -1;
            }
            else
            {
                Console.WriteLine($"Poped element is: {elements[top]}");
                return elements[--top];
            }
        }
        public void PritStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.Write("Stack is: ");
                for (int i = 0; i <= top; i++)
                {
                    Console.Write($"{elements[i]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
