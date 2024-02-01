using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class MethodExtension
    {
        public static string method(this string str)
        {
            if(str=="Satya")
            {
                return " Ok";
            }
            return "Not ok";
        }
    }
}
