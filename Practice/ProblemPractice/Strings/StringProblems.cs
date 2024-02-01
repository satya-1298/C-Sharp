using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProblemPractice.Strings
{
    public class StringProblems
    {
        public static void Create()
        {
            string str = "Hello,Everyone";
            Console.WriteLine(str);
        }
        //Write a program in C# Sharp to compare two strings without using a string library functions.
        public static void Compare()
        {
            Console.WriteLine("Enter a string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            if (str1.Length == str2.Length)
            {
                if (str1 == str2)
                {
                    Console.WriteLine("They are equal");
                }
                else
                {
                    Console.WriteLine("Not equal");
                }
            }
            else
            {
                Console.WriteLine("String length are not compatable");
            }

        }
        //Write a C# Sharp program to read a string through the keyboard and sort it using bubble sort.
        public static void Sort()
        {
            Console.WriteLine("No.of strings");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} strings", n);
            string temp = " ";
            string[] s = new string[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }

            Console.WriteLine("Sorted strings are");
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (s[i].CompareTo(s[j]) > 0)
                    {
                        temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            foreach (string sen in s)
            {
                Console.WriteLine(sen);
            }
        }
        //Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case.
        public static void CaseCheck()
        {
            Console.WriteLine("Enter a Character");
            char c = Convert.ToChar(Console.ReadLine());
            string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (s.Contains(c))
            {
                Console.WriteLine("It is a Upper Case");
            }
            else
            {
                Console.WriteLine("It is a Lower case");
            }
        }
        //Write a C# Sharp program to compare the last names of two people. It then lists them in alphabetical order.
        public static void CompareLastWord()
        {
            Console.WriteLine("Enter a");
        }
        //.** Write a C# Sharp program to demonstrate that you compare ordinals and compare using different sort orders.
        //**Write a C# Sharp program to concatenate three strings and display the result.
        public static void Merge()
        {
            Console.WriteLine("Enter a string");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter a string");
            string s2 = Console.ReadLine();

            Console.WriteLine("Enter a string");
            string s3 = Console.ReadLine();
            string add = String.Concat(s1, s2, s3);
            Console.WriteLine(add);
        }
        //** Write C# Sharp program to check whether a string occurs at the end of another string.
        //**Write a C# Sharp program to reverse the case (upper->lower, lower->upper) of all the characters in a given string.
        public static void ChangeCases()
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            string chstr = " ";
            char c = ' ';
            for (int i = 0; i < str.Length; i++)
            {
                c = str[i];
                if (char.IsLower(c))
                {
                    chstr = chstr + char.ToUpper(c);
                }
                else
                {
                    chstr = chstr + char.ToLower(c);
                }
            }
            Console.WriteLine(chstr);
            //string low=str.ToLower();
            //string high=str.ToUpper();
            //Console.WriteLine("String in UpperCase  : " + high);
            //Console.WriteLine("String in Lower case : "+low);



        }
        // Write a C# Sharp program to alternate the case of each letter in a
        // given string. The first letter of this string must be uppercase.
        public static void LetterUppercase()
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            string chstr = " ";
            char c = ' ';
            for (int i = 0; i < str.Length; i++)
            {
                c = str[i];

                if (i % 2 != 0)
                {
                    if (char.IsLower(c)||char.IsUpper(c))

                    {
                        chstr = chstr + char.ToLower(c);
                    }
                }
                else
                {
                    chstr = chstr +char.ToUpper(c);
                }

            }
            Console.WriteLine(chstr);

        }
        //Write a C# Sharp program to count the number of duplicate characters (case sensitive)
        //including spaces in a given string. If there are no duplicates, return 0.
        public static void Duplicate()
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            string group = Convert.ToString(str.GroupBy(s => s).Count(g => g.Count() > 1));

            Console.WriteLine(group);



        }

        public static void MaskChar()
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            if (input.Length < 2)
            {
               Console.WriteLine(input);
            }

            char firstChar = input[0];
            char lastChar = input[input.Length - 1];

            // Create a mask string with asterisks '*' for the middle characters.
            string mask = " ";
            for(int i = 1; i < input.Length-1; i++)
            {
                mask = mask + '*';
            }

            // Combine the first character, mask, and the last character to form the output.
            Console.Write("{0}{1}{2}", firstChar, mask, lastChar);
        }
        public static void FindIndex()
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            int count = 0;
            char ch = ' ';
            string str2 = " ";
            for (int i = 0; i < str.Length; i++)
            {
             
                ch = str[i];
                if(char.IsUpper(ch))
                {
                    Console.WriteLine("Upper letter in the position "+i);
                }
              
              
            }
           
        }
        public static void ChangeIndex2()
        {

            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
           
            char ch = ' ';
            string str2 = " ";
            Console.WriteLine("Enter index Position");
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                ch= str[i];
                if (i==index)
                {
                    str2 = str2 + char.ToUpper(ch);
                }
                else
                {
                    str2 = str2 + ch;
                }
            }
            Console.WriteLine(str2);

        }
    }
}
