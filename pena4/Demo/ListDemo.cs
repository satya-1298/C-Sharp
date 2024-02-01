using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ListDemo
    {
        public void values()
        {
            
            string temp;
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            List<string> list2 = new List<string>();    
            list2.Add("4");
            list2.Add("2");
            list2.Add("6");
            List<string> strings = new List<string>();
            foreach (var item in list)
            {
                strings.Add(item.ToString());
            }
            foreach (var item in list2)
            {
                strings.Add(item.ToString());
            }

            foreach (var item in strings)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(strings.Count());
            for(int i=0; i<strings.Count; i++)
            {
                for(int j=i; j<strings.Count; j++)
                {
                    if (strings[i].CompareTo( strings[j])>0)
                    {
                        temp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = temp;
                    }

                }
            }
            Console.WriteLine("list is");
            foreach (var item in strings)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}
