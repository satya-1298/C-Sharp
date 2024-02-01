using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    public  class StringIndex
    {
        public object Index()
        {
            string str = "Hello hfhg";
            Console.WriteLine("Enter a value");
            int f = Console.Read();
            Console.WriteLine("Enter a value");
            ConsoleKeyInfo key = Console.ReadKey(); 
            return new { Ascii=(int)key.Key, key.KeyChar };
        }
    }
}
