using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPractice.Exercise_One
{
    public class Rectangle_Prob
    {
        //private double Width;
        //private double Height;
        Measure measure=new Measure();
        double area, perimeter;
       public void Setting(double width,double length)
       {
            this.measure.Width = width;
            this.measure.Length = length;
       }
        public double Width_Getting()
        {
            return measure.Width;
        }
        public double Length_Getting() 
        {
            return measure.Length;
        }

        public double Rectangle_Area()
        {
            return measure.Length * measure.Width;
        }
        public double Rectangle_Perimeter()
        {
           return 2 * (measure.Width + measure.Length);
        }
        public void Show()
        {
            Console.WriteLine("Width of rectangle - "+Width_Getting());
            Console.WriteLine("Length of rectangle - "+Length_Getting());
            Console.WriteLine("Area of rectangle - "+Rectangle_Area());
            Console.WriteLine("Perimeter of rectangle - "+Rectangle_Perimeter());

        }
    }
}
