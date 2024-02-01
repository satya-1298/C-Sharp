using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Fibbanocci
    {
        public int Fib(int n)
        {
            try
            {
                if(n < 0)
                {
                    throw new StackOverflowException("InValid Value ,Only Positive Integers are allowed");
                }
                if (n == 0)
                {
                    return 0;
                }
                else if (n == 1)
                {
                    return 1;
                }
                else
                {
                    int val = Fib(n - 1) + Fib(n - 2);
                    return val;
                }
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }
    }
}
