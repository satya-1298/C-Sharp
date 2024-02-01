using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ClimbStair
    {
            public int ClimbStairs(int n)
            {
                int a = 1, b = 2, c = 0;
                if (n == 1)
                {
                    return 1;
                }
                if (n == 2)
                {
                    return 2;
                }
                if (n > 2)
                {
                    for (int i = 2; i < n; i++)
                    {
                        c = a + b;
                        a = b;
                        b = c;
                    }
                }
                return c;
            }
    }
}
