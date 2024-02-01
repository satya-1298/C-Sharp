using System;

namespace Demo
{
    public class Unique
    {
        public int FirstUniqChar(string s)
        {
            int charcount;

            for (int i = 0; i < s.Length; i++)
            {
                charcount = 1; 

                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j && s[i] == s[j])
                    {
                        charcount++; 
                    }
                }

                if (charcount == 1)
                {
                    Console.WriteLine(i);
                    return i;
                }
            }

            Console.WriteLine(-1);
            return -1; 
        }
    }
}
