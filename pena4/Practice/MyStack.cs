using System;
using System.Collections.Generic;

namespace Practice
{
    public class MyStack
    {
        Queue<int> queue;

        public MyStack()
        {
            queue = new Queue<int>();
        }
       
        public void Push(int x)
        {
            try
            {
                queue.Enqueue(x);
                for (int i = 0; i < queue.Count - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Pop()
        {
            try
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine("Popped Element: " + queue.Dequeue());
                }
                else
                {
                    throw new InvalidDataException("Stack is Empty");
                }
            }
            catch(InvalidDataException e) 
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Top()
        {
            try
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine("Top Element is: " + queue.Peek());
                }
                else
                {
                    throw new InvalidDataException("Stack is Empty");
                }
            }
            catch (InvalidDataException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Empty()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine( true);
            }
            Console.WriteLine (false);   
        }
    }

}
