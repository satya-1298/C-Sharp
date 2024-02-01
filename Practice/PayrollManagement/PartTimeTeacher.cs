using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement
{
    public class PartTimeTeacher:Teacher
    {
        public double slot {  get; set; }
        public PartTimeTeacher():base()
        {
            slot = 0;
        }
        public PartTimeTeacher(double slot,int code,string name):base(code,name)
        {
            this.slot = slot;
        }
        public override double GetSalary()
        {
           double salary = slot * 50000;
           return salary;
        }
    }
}
