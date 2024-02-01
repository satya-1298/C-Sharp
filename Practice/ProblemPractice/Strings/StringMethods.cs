using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPractice.Strings
{
    public class StringMethods
    {
        //length
        //substring
        //concatenation
        //joining
        //comparison
        //searching-contains,startswith,endswith,indexof,lastindexof
        //case-tolower,toupper
        //trimming-trim,trimstart,trimend
        //Splitting
        //Replace
        //Formatting
        //isnulllorWhiteSpace
        public void MethodPractce()
        {
            Console.WriteLine("Ente a string");
            string str=Console.ReadLine();
            Console.WriteLine("Length of string "+str.Length);
            Console.WriteLine("To Lower case "+str.ToLower());
            Console.WriteLine("To UpperCase "+str.ToUpper());
            Console.WriteLine("Trim String "+str.Trim());
            Console.WriteLine("Start trim "+str.TrimStart());
            Console.WriteLine("Ending trim "+str.TrimEnd());
            Console.WriteLine("Substring " + str.Substring(3));
            Console.WriteLine("Split the string ");
            string[] splitarr=str.Split(',');
            Console.WriteLine(splitarr[0]);
        }
        public static void StringLength()
        {
            Console.WriteLine("Enter the length of array");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            string[] strArr = new string[n];
            for(int i = 0;i<n;i++)
            {
                strArr[i] = Console.ReadLine();
            }
            Console.WriteLine(strArr.Length);
           

        }
        public static void Concatination()
        {
            Console.WriteLine("Enter the length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first array elements");
            string[] strArr = new string[n];
            for (int i = 0; i < n; i++)
            {
                strArr[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Enter second array elements");
            string[] strArr2 = new string[n];
            for (int i = 0; i < n; i++)
            {
                strArr2[i] = Console.ReadLine();
            }
            string[] newstr = newstr = strArr.Concat(strArr2).ToArray();
            Console.WriteLine("Concatinated array is ");
            for (int i = 0; i<newstr.Length; i++)
            {
                Console.WriteLine(newstr[i]);
            }
           
            //foreach (string str2 in newstr)
            //{
            //    Console.WriteLine(str2);
            //}

        }
        public static void ChangeCase()
        {
            Console.WriteLine("Enter the length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array elements");
            string[] strArr = new string[n];
            string upper = " ";
            string lower = " "; 
            char ch = ' ';
            for (int i = 0; i < n; i++)
            {
                strArr[i] = Console.ReadLine();
            }
            for(int i = 0;i<strArr.Length;i++)
            {
                
                for(int j = 0; j < strArr[i].Length; j++)
                {
                    ch = strArr[i][j];
                    if(char.IsLower(ch)||char.IsUpper(ch))
                    {
                        upper=upper+(char.ToUpper(ch));
                        lower=lower+(char.ToLower(ch));
                    }

                }
                Console.WriteLine("Upper is "+upper);
                upper= " ";
                Console.WriteLine("Lower is " + lower);
                lower= " ";
            }

        }
        public static void SplitString()
        {
            Console.WriteLine("Enter the length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  array elements");
            string[] strArr = new string[n];
            string[] splitarr= new string[n];
            for (int i = 0; i < n; i++)
            {
                strArr[i] = Console.ReadLine();
            }
            for(int i = 0;i< strArr.Length;i++)
            {
                splitarr = strArr[i].Split('e');//if i given Hello - H  and llo will split to different lines by removing e
                foreach (string str in splitarr)
                {
                    Console.WriteLine(str);
                }
            }
           
        }
        public static void JoinString()
        {

        }
        public static void SearchString()
        {
            Console.WriteLine("Enter the length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  array elements");
            string[] strArr = new string[n];
            string[] splitarr = new string[n];
            for (int i = 0; i < n; i++)
            {
                strArr[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the character ");
            char ch = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < strArr.Length; i++)
            {
                //if (strArr[i].ToLower().Contains(ch))
                //{
                //    Console.WriteLine("Character Contains:"+strArr[i]);
                //}
                //if (strArr[i].ToLower().StartsWith(ch))
                //{
                //    Console.WriteLine("Character Starts - "+strArr[i]);
                //}
                if (strArr[i].ToLower().EndsWith(ch))
                {
                    Console.WriteLine("Ends with - "+strArr[i]);
                }
               
            }
        }
        public static void Replace()
        {

        }
    }
}
