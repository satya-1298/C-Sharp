using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Fact
    {
        public void value()
        {
            try
            {

                int factorial = 1, n, i;
                Console.WriteLine("Enter  a number");
                n = Convert.ToInt32(Console.ReadLine());
                if( n == 0 )
                {
                    throw new NullReferenceException("Value cannot be Zero");
                }
                
                if (n < 32 && n > 0)
                {
                    while (n > 0)
                    {
                        factorial = n * factorial;
                        n--;

                    }
                    Console.WriteLine("factorial is :{0} ", factorial);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Entered value is out of range");
                }
            }
            catch(FormatException)
            {
                throw new ApplicationException("Enter correct input!!");
            }
          
        }

    }
}
