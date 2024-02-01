using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Lengthoflast
    {
       
            public int LengthOfLastWord(string s)
            {
                int length = 0;
                bool foundNonSpace = false;

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] != ' ')
                    {
                        // Found a non-space character
                        foundNonSpace = true;
                        length++;
                    }
                    else if (foundNonSpace)
                    {
                        // Found a space after the last word
                        break;
                    }
                }
            Console.WriteLine(length);
                return length;

            }
        
    }
}
