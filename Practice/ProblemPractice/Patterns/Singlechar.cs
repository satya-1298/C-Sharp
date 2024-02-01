using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPractice.Patterns
{
    public class Singlechar
    {
        public void Pattern()
        {
            int i, j, num;
            Console.WriteLine("Enter a number");
            num=int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    //Console.Write("* "); //star value* ** ***

                    Console.Write(i + " ");//number value 1 22 333

                    //Console.Write(j + " ");// 1 12 123

                }
                Console.WriteLine();
            }

        }
    }
}
