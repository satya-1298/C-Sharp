using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    public class Frequency2
    {
        public char Normal(string s)
        {
            int count = 0, maxcount=0;
            char frequentChar = ' ';
            char[] chars=s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                for(int j = 1; j < chars.Length; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        count++;
                        
                    }
                }
                if (count > maxcount)
                {
                    frequentChar = chars[i];
                    maxcount = count;
                }
            }
            return frequentChar;
        }
    }
}
