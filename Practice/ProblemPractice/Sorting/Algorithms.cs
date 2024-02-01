using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPractice.Sorting
{
    public class Algorithms
    {
        public static void Insertionsort()
        {
            Console.WriteLine("Enter the length of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int val, count = 0;
            Console.WriteLine("Enter elements into array");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element are {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                val = arr[i];
                
                for (int j = i - 1; j >= 0;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    
                }
            }
            Console.Write(" Sorted Array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }



        }
        public static void BubbleSort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int r in arr)
            {
                Console.WriteLine(r + " ");

            }
        }
    }
}
