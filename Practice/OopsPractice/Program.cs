using OopsPractice.Exercise_One;
using System.Drawing;

namespace OopsPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Rectangle_Prob rectangle_Prob = new Rectangle_Prob();
            while (true)
            {
                Console.WriteLine("1-Setting values");
                Console.WriteLine("2-Getting width Value");
                Console.WriteLine("3-Getting Length Value");
                Console.WriteLine("4-Area ");
                Console.WriteLine("5-Perimeter");
                Console.WriteLine("6-Show all the result");
                Console.WriteLine("Enter your option");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        rectangle_Prob.Setting(32, 55);
                        break;
                    case 2:
                        rectangle_Prob.Width_Getting();
                        break;
                    case 3:
                        rectangle_Prob.Length_Getting();
                        break;
                    case 4:
                        rectangle_Prob.Rectangle_Area();
                        break;
                    case 5:
                        rectangle_Prob.Rectangle_Perimeter();
                        break;
                    case 6:
                        rectangle_Prob.Show();
                        break;
                }
            }
        }
    }
}
   