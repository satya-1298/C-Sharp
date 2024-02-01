using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    public class Remove
    {
        public string Removestring(int position)
        {
            string[] strings = new string[] { "sai", "satya" };
            if (strings != null && position > strings.Length)
            {
                for (int i = 0; i < strings.Length; i++)
                {
                    if (i == position)
                    {
                        strings[i] = strings[i + 1];
                    }
                    return strings[i];

                }
            }
            return string.Empty;
        }
    }
}
