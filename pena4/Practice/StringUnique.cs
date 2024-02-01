using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class StringUnique
    {

        public void Find(string s)
        {
            try
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
                        return;
                    }
                }

            }
            catch(NullReferenceException ex)
            {
                throw new Exception(ex.Message);
            }
            catch(FormatException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
