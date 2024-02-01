using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    public class Frequency
    {
        public Dictionary<char,int> CountElement(string s)
        {
            //satya
            Dictionary<char,int> count= new Dictionary<char,int>();
            foreach(char c in s)
            {
                if(count.ContainsKey(c))
                {
                    count[c]++; 
                }
                else
                {
                    count[c] = 1;
                }
            }
            var a = count.Max(x => x.Value);
            var val = count.Where(x => x.Value == a).ToDictionary(x=>x.Key,x=>x.Value);
            return val;

        }
    }
}
