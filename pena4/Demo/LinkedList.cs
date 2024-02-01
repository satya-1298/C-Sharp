using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class LinkedList
    {
        public Node head;
        public void Add(int x) 
        {
            Node node = new Node(x);
            if (head == null)
            {
                head = node;
            }
            
            {
                Node temp= head;
                while(temp.next != null)
                {
                    temp= temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted in to Linked list ", x);
        }
    }
}
