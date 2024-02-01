using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    public class MethodOverridding
    {
        public virtual void Car()
        {
            Console.WriteLine("The Color is Red");
        }
    }
    public class Color:MethodOverridding
    {
        public override void Car()
        {
            Console.WriteLine("Price");
        }
    }
}
