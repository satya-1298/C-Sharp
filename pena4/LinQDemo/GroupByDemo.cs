using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQDemo
{
    public class GroupByDemo
    {
        public void Details()
        {
            List<Student> students = new List<Student>()
            {
               new Student(){ Id = 1, Name = "Satya", Gender = "Female" },
               new Student(){ Id = 2,Name="Kiran",Gender="Male"},
               new Student(){ Id = 1, Name = "Sagar", Gender = "Male" },
               new Student(){ Id = 1, Name = "DIvya", Gender = "Female" }
            };
            Console.WriteLine("\n");
            var info=from student in students where student.Gender == "Female" select student;
            foreach(Student student in info)
            {
                Console.WriteLine("Name : {0} , Gender : {1}, count : {2}",student.Name ,student.Gender,info.Count());
            }
            Console.WriteLine("\n");
            var info2 =students.Where(x=>x.Gender =="Male").ToList();
            foreach (Student student in info2)
            {
                Console.WriteLine("Name : {0} , Gender : {1}", student.Name, student.Gender);
            }
        }

    }
}
