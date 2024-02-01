using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement
{
    public class Manager:IManager
    {
        List<PartTimeTeacher> ptTeacher = new List<PartTimeTeacher>();
        List<FullTimeTeacher> ftTeachers = new List<FullTimeTeacher>();
        List<Teacher> teachers = new List<Teacher>();
        public void ListOfTeachers()
        {
            var partTimeTeacher = new List<PartTimeTeacher>
            {
                new PartTimeTeacher { code=1,name="Gani",slot=3},
                new PartTimeTeacher {code=3, name="Divya",slot =4},
                new PartTimeTeacher {code=5,name="Shanu",slot=6}
            };

            var fullTimeTeacher = new List<FullTimeTeacher>
            {
                 new FullTimeTeacher {code=1, salary_Coeffient=3, name="Sitva" },
                 new FullTimeTeacher {code=6, salary_Coeffient=8, name="Anu" },
                 new FullTimeTeacher {code=3, salary_Coeffient=9, name="Pooja" }
            };

            ftTeachers.AddRange(fullTimeTeacher);

            ptTeacher.AddRange(partTimeTeacher);

            teachers.AddRange(fullTimeTeacher);
            teachers.AddRange(partTimeTeacher);

            foreach (var teacher in teachers)
            {
                teacher.Show();
                teacher.GetSalary();
               
            }
            Console.WriteLine("...............................");
            Console.WriteLine("FullTime Teacher List");
            Console.WriteLine("...............................");
            foreach (FullTimeTeacher f in ftTeachers)
            {
                Console.Write("Code - {0} , Name - {1} , SalaryCoefficient - {2} ,salary - {3} \n", f.code, f.name, f.salary_Coeffient ,f.GetSalary());
            
            }
            Console.WriteLine("...............................");
            Console.WriteLine("PartTime Teacher List");
            Console.WriteLine("...............................");
            foreach (PartTimeTeacher p in ptTeacher)
            {
                Console.Write("Code - {0} , Name - {1} , Slot - {2} , Salary - {3}  \n", p.code, p.name, p.slot, p.GetSalary());
                
            }
        }
        public void Teachers_High_Salary()
        {
           
            var ptSalary = ptTeacher.OrderByDescending(p => p.slot).FirstOrDefault();
            var ftSalary=ftTeachers.OrderByDescending(p=>p.salary_Coeffient).FirstOrDefault();
            if (ptSalary != null && ftSalary != null)
            {
                Console.WriteLine(".................................................................");
                Console.WriteLine("Full Time Teacher With Highest Salary \n Code - {0} , Name - {1} , Salary - {2} ", ftSalary.code, ftSalary.name,ftSalary.GetSalary());
                Console.WriteLine("Part Time Teacher With Highest Salary \n Code - {0} , Name - {1} , Salary - {2} ", ptSalary.code, ptSalary.name,ptSalary.GetSalary());
                Console.WriteLine("...................................................................");
            }
        }
        public void Slot_PTeachers()
        {
            double add = 0;
            var sum = ptTeacher.OrderBy(p => p.slot).ToList();
            foreach (var p in sum)
            {
                add = add + p.slot;
            }
            Console.WriteLine(add);
        }
        public void Sort_Salary_Desc()
        {
            var salary=teachers.OrderBy(p=>p.GetSalary()).ToList();
           // var salary = ptTeacher.OrderByDescending(p => p.slot).ToList();

            Console.WriteLine("Teachers with Salaries in Descending Order:");

            foreach (var teacher in salary)
            {
                Console.WriteLine("Code - {0}, Name - {1}, Salary - {2}", teacher.code, teacher.name, teacher.GetSalary());
            }

        }
        public void DisplayName_By_Char()
        {
            char ch = 'T';
            var namech = teachers.Where(p => p.name.ToUpper().Contains(ch)).ToList();
            if(namech.Any())
            {
                foreach(var p in namech)
                {
                    p.Show();
                }
            }
            else
            {
                Console.WriteLine("No Name with T");
            }

        }
    }
}
