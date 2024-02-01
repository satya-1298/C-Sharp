using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement
{
    public class Employee
    {
        public int code {  get; set; }  
        public string name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string gender {  get; set; } 
        public int no_of_children {  get; set; }
        public double salary {  get; set; }
        double income ,allowance=0;
        public Employee()
        {
            
        }
        public Employee(int code,string name,DateTime date_of_birth,string gender,int no_of_children,double salary)
        {
            this.code = code;
            this.name = name;
            this.date_of_birth = date_of_birth;
            this.gender = gender;
            this.no_of_children = no_of_children;
            this.salary = salary;
            
        }
        public void Show()
        {
            if(no_of_children==0)
            {
                allowance = 0;
                Console.WriteLine("There is no allowance");
            }
            else if(no_of_children>=2)
            {
                allowance = 1000000;
                income = salary + allowance;
                Console.WriteLine(income);
            }
            else
            {
                allowance = 1500000;
                income = salary+allowance;
                Console.WriteLine(income);
            }
        }
      
    }
}
