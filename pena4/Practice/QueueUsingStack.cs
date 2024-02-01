using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class QueueUsingStack
    {
        Stack<int> s;

        public QueueUsingStack()
        {
            s = new Stack<int>();
        }

        public void Push(int x)
        {
            try
            {
                if (s.Count == 0)
                {
                    s.Push(x);
                }
                else
                {
                    int temp = s.Pop();
                    Push(x);
                    s.Push(temp);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int Pop()
        {
            try
            {
                if (s.Count == 0)
                {
                    throw new InvalidOperationException("Queue is Empty");
                }
                return s.Pop();
            }
            catch (InvalidOperationException n)
            {
                Console.WriteLine(n.Message);
                return 0;
            }
        }

        public int Peek()
        {
            try
            {
                if(s.Count == 0)
                {
                    throw new InvalidOperationException("Queue is Empty");
                }
                return s.Peek();
            }
            catch(InvalidOperationException n)
            {
                Console.WriteLine(n.Message);
                return 0;
            }
        }

        public bool Empty()
        {
            return s.Count == 0;
        }
    }


    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */

}
