using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class OddEven
    {
        public void Number()
        {
            try
            {
                int n,a=9,b=0;
                Console.WriteLine("Enter a number");
                n = Convert.ToInt32(Console.ReadLine());
                if(n%2==0)
                {
                    Console.WriteLine("It is even");
                }
                else
                {
                    Console.WriteLine("It is odd");
                }
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                throw new ApplicationException("Input in wrong exception", ex);//wrapping exception
                //throw ex;
            }
            catch(DivideByZeroException nx)
            {
                Console.WriteLine(nx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
