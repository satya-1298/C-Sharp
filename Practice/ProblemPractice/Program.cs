using ProblemPractice.ArrayProblems;
using ProblemPractice.Collections;
using ProblemPractice.DataTypes;
using ProblemPractice.Dates;
using ProblemPractice.Patterns;
using ProblemPractice.Sorting;
using ProblemPractice.Strings;

namespace ProblemPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Practice practice = new Practice();
            ArrayDemo arrayDemo = new ArrayDemo();

            while (true)
            {
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Enter a option");
                Console.WriteLine("------------------------DataTypes-----------------");
                Console.WriteLine("1-Pattern program");
                Console.WriteLine("2-Reverse a String");
                Console.WriteLine("3-pattern reverse tri");
                Console.WriteLine("4-login Attempts");
                Console.WriteLine("5-Arthimatic Operation");
                Console.WriteLine("6-Perimeter of circle");
                Console.WriteLine("7-FunctionInteger");
                Console.WriteLine("8-Vol & Suf of Sphere");
                Console.WriteLine("9-Check Given input");
                Console.WriteLine("10 - check EvenOdd ");
                Console.WriteLine("11-Convert to Binary");
                Console.WriteLine("----------------------Array Problems-----------------");
                Console.WriteLine("12-Display Array");
                Console.WriteLine("13-Even-odd two arrays");
                Console.WriteLine("14-Addition of two matrix");
                Console.WriteLine("15-Matching of matrixes");
                Console.WriteLine("16-Find the duplicate elments");
                Console.WriteLine("17-Copy one array to another");
                Console.WriteLine("18-Desending of array");
                Console.WriteLine("19-Second largest number");
                Console.WriteLine("20-Sum of Left Diagonal");
                Console.WriteLine("21-Odd numbers from array");
                Console.WriteLine("------------------------Strings-----------------------");
                Console.WriteLine("22-Create a string and display");
                Console.WriteLine("23-Compare two Strings");
                Console.WriteLine("24-Sort three strings");
                Console.WriteLine("25-Check the char case");
                Console.WriteLine("26-Merge three strings");
                Console.WriteLine("27-Changing the cases");
                Console.WriteLine("28-Find the duplicate words");
                Console.WriteLine("------------------------DateTime----------------------");
                Console.WriteLine("29-Display the date formate");
                Console.WriteLine("30-Sequence of friction");
                Console.WriteLine("31-Display Date time in a input formate");
                Console.WriteLine("32-Date time to Local Time");
                Console.WriteLine("33-DateTime Equaivalent");
                Console.WriteLine("------------------------Sorting----------------------");
                Console.WriteLine("34-Insertion Sorting");
                Console.WriteLine("35-BubbleSorting");
                Console.WriteLine("------------------------Review-----------------------");
                Console.WriteLine("36-string into upper <=> lower case");
                Console.WriteLine("37-Count duplicate words");
                Console.WriteLine("38-Masking the certain part of string");
                Console.WriteLine("39-Find UpperLetter position");
                Console.WriteLine("40-Convert letter to uppercase in given index");
                Console.WriteLine("41-String Methods");
                Console.WriteLine("42-String Length Method");
                Console.WriteLine("43-String Concat Method");
                Console.WriteLine("44-String cases");
                Console.WriteLine("45-String Split");
                Console.WriteLine("46-String Joining");
                Console.WriteLine("47-String Search");
                Console.WriteLine("48-Replace string");
                Console.WriteLine("-------------------Collections-----------------");
                Console.WriteLine("49-ArrayList");
                Console.WriteLine("50-List");
                Console.WriteLine("51-Dictionary");
                Console.WriteLine("52-Queue");
                Console.WriteLine("53-Stack");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("\n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Singlechar singlechar = new Singlechar();
                        singlechar.Pattern();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        practice.ReverseString();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        practice.Pattern();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        practice.Login();
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        practice.Arthimatic();
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        practice.CircleArea();
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        practice.Function();
                        Console.WriteLine("\n");
                        break;
                    case 8:
                        practice.Sphere();
                        Console.WriteLine("\n");
                        break;
                    case 9:
                        practice.Check();
                        Console.WriteLine("\n");
                        break;
                    case 10:
                        practice.EvenOdd();
                        Console.WriteLine("\n");
                        break;
                    case 11:
                        practice.Binary();
                        Console.WriteLine("\n");
                        break;
                    case 12:
                        arrayDemo.Display();
                        Console.WriteLine("\n");
                        break;
                    case 13:
                        arrayDemo.EvenOddArray();
                        Console.WriteLine("\n");
                        break;
                    case 14:
                        arrayDemo.Matrix();
                        Console.WriteLine("\n");
                        break;
                    case 15:
                        arrayDemo.MatchMatrix();
                        Console.WriteLine("\n");
                        break;
                    case 16:
                        arrayDemo.Duplicate();
                        Console.WriteLine("\n");
                        break;
                    case 17:
                        arrayDemo.Copy();
                        Console.WriteLine("\n");
                        break;
                    case 18:
                        arrayDemo.Descending();
                        Console.WriteLine("\n");
                        break;
                    case 19:
                        arrayDemo.Secondlarge();
                        Console.WriteLine("\n");
                        break;
                    case 20:
                        arrayDemo.LeftMatrix();
                        Console.WriteLine("\n");
                        break;
                    case 21:
                        arrayDemo.OddArray();
                        Console.WriteLine("\n");
                        break;
                    case 22:
                        StringProblems.Create();
                        Console.WriteLine("\n");
                        break;
                    case 23:
                        StringProblems.Compare();
                        Console.WriteLine("\n");
                        break;
                    case 24:
                        StringProblems.Sort();
                        Console.WriteLine("\n");
                        break;
                    case 25:
                        StringProblems.CaseCheck();
                        Console.WriteLine("\n");
                        break;
                    case 26:
                        StringProblems.Merge();
                        Console.WriteLine("\n");
                        break;
                    case 27:
                        StringProblems.ChangeCases();
                        Console.WriteLine("\n");
                        break;
                    case 28:
                        StringProblems.Duplicate();
                        Console.WriteLine("\n");
                        break;
                    case 29:
                        DateProblems.Display();
                        Console.WriteLine("\n");
                        break;
                    case 30:
                        DateProblems.Fractional();
                        Console.WriteLine("\n");
                        break;
                    case 31:
                        DateProblems.DateStyle();
                        Console.WriteLine("\n");
                        break;
                    case 32:
                        DateProblems.LocalTime();
                        Console.WriteLine("\n");
                        break;
                    case 33:
                        DateProblems.ConvertDateTime();
                        Console.WriteLine("\n");
                        break;
                    case 34:
                        Algorithms.Insertionsort();
                        Console.WriteLine("\n");
                        break;
                    case 35:
                        Algorithms.BubbleSort();
                        Console.WriteLine("\n");
                        break;
                    case 36:
                        StringProblems.LetterUppercase();
                        Console.WriteLine("\n");
                        break;
                    case 37:
                        StringProblems.Duplicate();
                        Console.WriteLine("\n");
                        break;
                    case 38:
                        StringProblems.MaskChar();
                        Console.WriteLine("\n");
                        break;
                    case 39:
                        StringProblems.FindIndex();
                        Console.WriteLine("\n");
                        break;
                    case 40:
                        StringProblems.ChangeIndex2();
                        Console.WriteLine("\n");
                        break;
                    case 41:
                        StringMethods stringMethods = new StringMethods();
                        stringMethods.MethodPractce();
                        Console.WriteLine("\n");
                        break;
                    case 42:
                        StringMethods.StringLength();
                        Console.WriteLine("\n");
                        break;
                    case 43:
                        StringMethods.Concatination();
                        Console.WriteLine("\n");
                        break;
                    case 44:
                        StringMethods.ChangeCase();
                        Console.WriteLine("\n");
                        break;
                    case 45:
                        StringMethods.SplitString();
                        Console.WriteLine("\n");
                        break;
                    case 46:
                        StringMethods.JoinString();
                        Console.WriteLine("\n");
                        break;
                    case 47:
                        StringMethods.SearchString();
                        Console.WriteLine("\n");
                        break;
                    case 48:
                        StringMethods.Replace();
                        Console.WriteLine("\n"); 
                        break;
                    case 49:
                        CollectionsProblems.ArrayList_Prog();
                        Console.WriteLine("\n");
                        break;
                    case 50:
                        CollectionsProblems.List_prog();
                        Console.WriteLine("\n");
                        break;
                    case 51:
                        CollectionsProblems.Dictionary_Prog();
                        Console.WriteLine("\n");
                        break;
                    case 52:
                        CollectionsProblems.Queue_prog();
                        Console.WriteLine("\n");
                        break;
                    case 53:
                        CollectionsProblems.Stack_Prog();
                        Console.WriteLine("\n");

                        break;
                    default:
                        Console.WriteLine("Invalid request");
                        Console.WriteLine("\n");
                        break;
                }
            }

        }
    }
}