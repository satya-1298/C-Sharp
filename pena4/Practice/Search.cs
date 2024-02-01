using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Search
    {
        public void Element(int val)
        {
            try
            {
                
                int[] arr = { 1, 5, 6, 7, 8 };
                //int[] arr = null;
                if (arr == null)
                {
                    throw new NullReferenceException("Array is null");
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == val)
                    {
                        Console.WriteLine("Found in Position : " + i);
                        return;
                    }

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine( ex.Message);
            }
        }
    }
}
