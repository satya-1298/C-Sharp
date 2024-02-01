using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPractice.ArrayProblems
{
    public class ArrayDemo
    {
        public void Display()
        {
            int[] arr=new int[10] {1,1,2,3,4,5,6,7,8,9}; 
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            
        }
        // Write a C# Sharp program to copy the elements of one array into another array.
        public void Copy()
        {
            Console.WriteLine("Enter the length of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr2 = new int[n];
            int flag = 0;
            Console.WriteLine("Enter elements into array");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element are {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < n; i++)
            {
                arr2[i] = arr[i];
            }
            for(int i = 0;i<n ; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            for( int i = 0;i<n ;i++)
            {
                if (arr[i] == arr2[i])
                {
                   flag= 1;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Copied ");
            }
            else { Console.WriteLine("Not Same"); }

        }
        // Write a C# Sharp program in to count duplicate elements in an array.
        public void Duplicate()
        {
            Console.WriteLine("Enter the length of array : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements into array");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Element are {0} : ",i);
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The duplicate elements are");
            for(int i = 0; i < arr.Length;i++)
            {
               
                for(int j = 1+i;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
        }
        //Write a C# Sharp program to count the frequency of each element in an array.
        public void Count()
        {
            Console.WriteLine("Enter the length of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements into array");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element are {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i < arr.Length;i++)
            {
                for( int j = 1+i; j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                    {

                    }
                }
            }
        }
       // Write a C# Sharp program to sort array elements in descending order.
       public void Descending()
        {
            Console.WriteLine("Enter the length of the array");
            int num=int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int temp = 0;
            
            Console.WriteLine("Enter the elements in array");
            for(int i = 0;i<num;i++)
            {
                Console.WriteLine("The elements are {0} : ",i);
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i<=num;i++)
            {
                for(int j = 1+i;j<arr.Length;j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j]= temp;
                    }
                   
                }
               
            }
            foreach ( int k in arr)
            {
                Console.WriteLine(k);
                

            }
        }
        //16. Write a C# Sharp program to find the second largest element in an array.
        public void Secondlarge()
        {
            Console.WriteLine("Enter the length of the array");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int temp = 0;

            Console.WriteLine("Enter the elements in array");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("The elements are {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= num; i++)
            {
                for (int j = 1 + i; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }

            }
            foreach (int k in arr)
            {
                Console.WriteLine(k);


            }
            Console.WriteLine(arr[1]);
        }
        //Write a program in C# Sharp to separate odd and even integers into separate arrays.

        public void EvenOddArray()
        {
            int n = 5;
            int[] arr = new int[n] ;
            int[] even= new int[n];
            int[] odd= new int[n];  
            for(int i = 0;i<n;i++)
            {
                Console.WriteLine("Enter  the elements at {0} : ",i );
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            int j = 0, k = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if ((arr[i]%2)== 0)
                {
                    even[j] = arr[i];
                    j++;
                }
                else
                {
                    odd[k]= arr[i];
                    k++;
                }
               
            }
            Console.WriteLine("Even are : ");
            for (int i = 0; i < j; i++)
            {
                Console.Write(even[i]);
            }
            Console.WriteLine("Odd are : ");
            for (int i = 0; i< k; i++)
            {
                Console.Write(odd[i]);
            }
        }

        // Write a C# Sharp program for the Addition of two matrixes.
        public void Matrix()
        {
            int[,] matrix1 = new int[2,2];
            int[,] matrix2 = new int[2,2];
            int[,] sum= new int[2,2];
            Console.WriteLine("Enter elements of first matrix");
            for(int i = 0;i<2 ; i++)
            {
                for(int j = 0;j<2 ; j++)
                {
                    Console.Write("Enter element {0},{1} : ", i,j);
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                

            }
            Console.WriteLine("Enter elements of second matrix");
            for (int i = 0;i< 2 ; i++)
            {
                for (int j = 0; j<2 ; j++)
                {
                    Console.Write("Enter elements{0},{1} :", i, j);
                    matrix2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0;i < 2 ; i++)
            {
                for(int j = 0; j<2 ;j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i,j];
                }
            }
            Console.WriteLine("Addition of two matrixes are ");
            for( int i = 0; i< 2 ; i++)
            {
                for( int j = 0;j < 2 ; j++)
                {
                    Console.Write("{0} ",sum[i, j]);
                }
                Console.WriteLine();
            }
        }
        //Write a C# Sharp program to find the sum of the left diagonals of a matrix.
        public void LeftMatrix()
        {
            int r = 2, c = 2;
            int[,] matrix1 = new int[2, 2];
            Console.WriteLine("Enter elements into matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Enter element {0},{1} : ", i, j);
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }


            }
            
            Console.WriteLine(" matrix is ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", matrix1[i, j]);
                }
                Console.WriteLine();
            }
            int d=0;
            //d = matrix1[0, 0] + matrix1[1, 1];
            //Console.WriteLine(d);
            if(r==c)
            {
                for(int i = 0; i < 2;i++)
                {
                    for(int j = 0; j < 2;j++)
                    {
                        if(i==j)
                        {
                            d = d + matrix1[i, j];
                        }
                    }
                }
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("they are not compatable to sum");
            }
        }
        // Write a C# Sharp program to get only odd values from a given integer array.
        public void OddArray()
        {
            int n = 5;
            int[] arr = new int[n];
            int[] odd = new int[n];
            int count=0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter  the elements at {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
              
                if ((arr[i] % 2) != 0)
                {
                    odd[j] = arr[i];
                    j++;
                    count = 1;
                }
               

            }
            if (count == 1)
            {
                Console.WriteLine("Odd are : ");
                for (int i = 0; i < j; i++)
                {
                    Console.Write(odd[i] +" ");
                }
            }
            else { Console.WriteLine("No odd numbers found"); }
        }

        // Write a C# Sharp program to accept two matrices and check equality.
        public void MatchMatrix()
        {
            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            int count = 0 ,r1=2,r2=3,c1=2,c2=2;
           

            Console.WriteLine("Enter elements of first matrix");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    Console.Write("Enter element {0},{1} : ", i, j);
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }


            }
            Console.WriteLine("Enter elements of second matrix");
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write("Enter elements{0},{1} :", i, j);
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (c1 != c2 || r1 != r2)
            {
                Console.WriteLine("They are not compatable");
            }
            else
            {
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        if (matrix1[i, j] != matrix2[i, j])
                        {
                            count = 1;
                            break;
                        }

                    }
                }
            }
            if(count == 0)
            {
                Console.WriteLine("\n They are matched");
            }
            else
            {
                Console.WriteLine("\n Not");
            }

        }
       
    }
}
