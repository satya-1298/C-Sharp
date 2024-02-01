using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class LengthOfLastWord
    {
            public int Word(string s)
            {
                int length = 0;
                bool foundNonSpace = false;

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] != ' ')
                    {
                        foundNonSpace = true;
                        length++;
                    }
                    else if (foundNonSpace)
                    {
                        break;
                    }
                }
                Console.WriteLine(length);
                return length;

            }
    }
}
