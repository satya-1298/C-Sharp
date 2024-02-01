using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPractice.Collections
{
    //C# collection types are designed to store, manage and manipulate similar data more efficiently.
    //Non-generic            Generic

    //ArrayList            List

    //HashTable           Dictionary

    //SortedList          SortedList

    //Stack               Stack

    //Queue               Queue
    public class CollectionsProblems
    {
        public static void ArrayList_Prog()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Satya");
            arrayList.Add(1.5);
            arrayList.Add(89.1f);
            arrayList.Add('f');
            Console.WriteLine("ArrayList using foreach loop");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("ArrayList using for loop");

            for (var i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
        //Creating a list of integers
        public static void List_prog()
        {
            List<int> list = new List<int>();

            list.Add(12);
            list.Add(30);
            list.Add(10);
            list.Add(5);
            list.Add(19);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of List - " + list.Count);
            Console.WriteLine("Capacity of List - " + list.Capacity);

            list.Add(7);
            list.Add(1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of List - " + list.Count);

            Console.WriteLine("Capacity of List - " + list.Capacity);
            Console.WriteLine("Find Element " + list.Contains(1));
            Console.WriteLine("Remove Element " + list.Remove(14));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********");
            Console.WriteLine("Removing Element in a Particular position");
            list.RemoveAt(4);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********");
            Console.WriteLine("Reversing the order of list");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********");
            Console.WriteLine("Sorting the List");
            list.Add(2);
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("********");
            Console.WriteLine("Deleting the Complete list");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }
        public  static void Dictionary_Prog()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("One", "Amalapuram");
            keyValuePairs.Add("Two", "Hyderabad");
            keyValuePairs.Add("Three", "Bangalore");
            keyValuePairs.Add("Four", "Chennai");

            //Print the value for key 
            Console.WriteLine("Print the value of key");
            Console.WriteLine(keyValuePairs["Two"]);
            Console.WriteLine("---------------------------------------");


            //Modify the value of key 
            Console.WriteLine("Modify the key value");
            keyValuePairs["Two"] = "Kakinada";
            Console.WriteLine(keyValuePairs["Two"]);
            Console.WriteLine("----------------------------------------");


            Console.WriteLine("Dictionary using for each loop");

            //Remove element from dictionary
            keyValuePairs.Remove("Three");

            foreach (KeyValuePair<string, string> element in keyValuePairs)
            {
                Console.WriteLine(element.Key + ":" + element.Value);
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Dictionary using for loop");
            for (int i = 0; i < keyValuePairs.Count; i++)
            {
                var item = keyValuePairs.ElementAt(i);
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
        public static void Queue_prog()
        {
            Queue queue = new Queue();
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue("sai");
            foreach(var  item in queue)
            {
                Console.WriteLine(item);
            }
            //dqueue-remove element 
            Console.WriteLine("Remove element");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count  - "+queue.Count);
            Console.WriteLine("Peek of element "+queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        public static void Stack_Prog()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push("hello");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();
            Console.WriteLine("Remove a element");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count - " + stack.Count);
            Console.WriteLine("Search  -  "+stack.Contains("hello"));//false
            Console.WriteLine("Search  -  " + stack.Contains(3));//true
        }
    }
}
