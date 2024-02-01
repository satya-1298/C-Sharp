using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{

    public class Practice
    {
        public static void CreateArray()
        {
            string[] arr = { "Adb", "sai", "satya" };
            char ch = 'a';
            char ch2 = 'A';
          
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                
                if (arr[i].ToLower().Contains(ch))
                {
                    for(int j = 0; j < arr[i].Length; j++)
                    {
                        if (arr[i][j] == ch || arr[i][j]==ch2)
                        {
                            count++;
                        }
                    }
                    
                    Console.WriteLine(arr[i]);
                    Console.WriteLine(count);
                    
                }
                
                
            }
        }
    }
}
