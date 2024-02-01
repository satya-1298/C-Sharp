using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class TwoSumArray
    {
        public void TwoSum(int[] nums, int target)
        {

            try
            {

               if(nums==null)
                {
                    throw new NullReferenceException("Array is Empty");
                }

                for (int i = 0; i < nums.Length; i++)
                    {
                        for (int j = 1; j < nums.Length; j++)
                        {
                            if (nums[i] + nums[j] == target)
                            {
                                Console.WriteLine("Indexes are {0},{1}", i, j);
                                return;
                            }


                        }
                    }
                
               
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
