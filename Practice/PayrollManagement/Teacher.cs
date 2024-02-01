using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement
{
    public abstract class Teacher
    {
        public int code {  get; set; }  
        public string name { get; set; }
        public Teacher() 
        { 

        }
        public Teacher(int code, string name)
        {
            this.code = code;
            this.name = name;
        }
        public void Show()
        {
            Console.WriteLine("Code : {0} , Name : {1} ",code,name);
        }
        public abstract double GetSalary();
    }
}
