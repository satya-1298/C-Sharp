using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement
{
    public  class FullTimeTeacher:Teacher
    {
        public double salary_Coeffient {  get; set; }
        public FullTimeTeacher():base()
        {
            salary_Coeffient = 0;
        }
        public FullTimeTeacher(double salaryCoeffient,int code,string name):base(code,name)
        {
            this.salary_Coeffient=salaryCoeffient;
        }
        public override double GetSalary()
        {
            double salary = salary_Coeffient * 200000;
            return salary;
        }
    }
}
