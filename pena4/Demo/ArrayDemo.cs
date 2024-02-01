using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ArrayDemo
    {
        public int TwoSum(int[] nums, int target)
        {
            int temp=0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return i;
                        
                    }

                }
            }
            return temp;
        }

    }
}
