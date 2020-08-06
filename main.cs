using System;

namespace ConsoleApplication1
{
    class Stack
    {
        private int[] ele;
        private int top;
        private int max;
        public Stack(int size)
        {
            ele = new int[size];
            top  = -1;
            max  = size;
        }

        public void push(int item)
        {
            if (top == max-1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                ele[++top] = item;
            }
        }

        public int pop()
        { 
            if(top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + ele[top]);
                return ele[top--];
            }
        }

        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
           int n=Convert.ToInt32(Console.ReadLine());
           int i;
            Stack S = new Stack(n);
            for(i=0;i<n;i++)
            {
            S.push(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Items are : ");
            S.printStack();

            S.pop();
            S.pop();
            S.pop();
        }
    }
}

