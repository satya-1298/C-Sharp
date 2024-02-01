using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a C# Sharp program that takes three letters and displays them in reverse order.

namespace ProblemPractice.DataTypes
{
    public class Practice
    {
        public void ReverseString()
        {
            Console.WriteLine("Enter a first char");

            char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter a second char");
            char c2= Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter a third char");
            char c3=Convert.ToChar(Console.ReadLine());
            Console.WriteLine(c3+" "+ c2+" "+c1);
        }

        // Write a C# Sharp program that takes a number and a width also a number. It then displays a triangle of that width using that number.
        public void Pattern()
        {
            int i, j;
            Console.WriteLine("Enter Width");
            int width=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            int w = width;
            for(i = 0; i < w; i++)
            {
                for(j = 0; j < width; j++)
                {
                    Console.Write(num+" ");
                 
                }
                Console.WriteLine();
                width--;
            }
        }

        //Write a C# Sharp program that takes userid and password as input (string type). After 3 unsuccessful attempts, the user will be rejected.
        public void Login()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter no.of attempts");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter UserId");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Passsword");
            string password=Console.ReadLine();
            Console.WriteLine("*******************LOGIN************************");
            for(int i = 1;i<=num;i++)
            {
                Console.Write("Enter UserId : ");
                int verifyId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a Passsword : ");
                string verifyPassword = Console.ReadLine();
                if(id!=verifyId ||password!=verifyPassword )
                {
                    Console.WriteLine("Invalid info", i);
                    Console.WriteLine("\n");
                    if(i==num)
                    {
                        Console.WriteLine("**************************************************");
                        Console.WriteLine("To many unsucessfull attempts! Account blocked");
                        Console.WriteLine("**************************************************");

                    }
                }
                else
                {
                    Console.WriteLine("Successful");
                    break;
                }
            }
           
        }
        //Write a C# Sharp program that takes two numbers as input and performs an operation
        //(+,-,*,x,/) on them and displays the result of that operation.
        public void Arthimatic()
        {
            Console.WriteLine("Enter first number");
            int n1=Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter second number");
            int n2=Convert.ToInt32(Console.ReadLine());
            int add = n1 + n2;
            Console.WriteLine("Addition : "+add);
            int sub = n1 - n2;
            Console.WriteLine("Subtraction : " + sub);
            int mul=n1* n2;
            Console.WriteLine("Multiplication : " + mul);
            int div = n1 / n2;
            Console.WriteLine("Division : " + div);
        }
        // Write a C# Sharp program that takes the radius of a circle as input and calculates the perimeter and area of the circle.
        public void CircleArea()
        {
            Console.WriteLine("Enter radius of circle");
            int rad=Convert.ToInt32(Console.ReadLine());
            double per=2*Math.PI*rad;
            Console.WriteLine(per);

        }
        //Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1
        //(using integer numbers for y, ranging from -5 to +5).
        public void Function()
        {
            Console.WriteLine("Enter start value ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end value");
            int end = Convert.ToInt32(Console.ReadLine());
            for(int y = start; y <= end; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine("({0})^2+2({0})+1={1}", y, x);
            }
        }
        //Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface
        //and volume of the sphere.
        public void Sphere()
        {
            Console.WriteLine("Enter radius");
            int rad = Convert.ToInt32(Console.ReadLine());
            double volume=4f/3f*Math.PI*(rad*rad*rad);
            Console.WriteLine("Volume of Sphere : " + volume);
            double surface=4*Math.PI*rad*rad;
            Console.WriteLine("Surface of Sphere : " + surface);
        }
        //Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        public void Check()
        {
            Console.WriteLine("Enter a Input");
            var input=Console.ReadLine();
            string vowle = "aeiouAEIOU";
            string digits = "1234567890";
            string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            string characters = "!@#$%^&*()_+=";
            if(vowle.Contains(input))
            {
                Console.WriteLine("This is vowel");
            }
            else if(digits.Contains(input)) 
            {
                Console.WriteLine("This is digits");
            }
            else if(characters.Contains(input))
            {
                Console.WriteLine("This is Special Charaters");
            }
            else if(consonants.Contains(input))
            {
                Console.WriteLine("This is Consonant");
            }
            else
            {
                Console.WriteLine("Input not identified");
            }
        }
        //Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.
        public void EvenOdd()
        {
            Console.WriteLine("Enter first number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2=Convert.ToInt32(Console.ReadLine());
            if(num1%2==0 && num2%2==0|| num1 % 2 != 0 && num2 % 2 != 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        // Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.
        public void Binary()
        {
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }
    }
}
//Write a C# Sharp program that takes distance and time as input and displays speed in kilometres per hour and miles per hour.

