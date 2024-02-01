using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeMangement
{
    public class Manager : IManager
    {
        ////Employee employee = new Employee();
        ArrayList list = new ArrayList();

        public void InputList(int size)
        {

            for (int i = 1; i <= size; i++)
            {
                Employee emp = new Employee();

                Console.WriteLine("Employee - {0}", i);
                Console.Write("Enter Employee Code: ");
                emp.code = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                emp.name = Console.ReadLine();

                Console.Write("Enter Date of Birth (): ");
                emp.date_of_birth = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Enter Gender: ");
                emp.gender = Console.ReadLine();

                Console.Write("Enter Number of Children: ");
                emp.no_of_children = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Salary: ");
                emp.salary = Convert.ToDouble(Console.ReadLine());

                // Add the employee to the list
                list.Add(emp);
            }
        }
        public void ShowList()
        {
            foreach (Employee emp in list)
            {
                Console.WriteLine("Code - {0}  , Name - {1} , DateOfBirth - {2} , Gender - {3} NoOfChildrens - {4} Salary - {5}",
                            emp.code, emp.name, emp.date_of_birth, emp.gender, emp.no_of_children, emp.salary);
            }
        }
        public void FemaleEmpCount()
        {
            int count = 0;

            foreach (Employee emp in list)
            {
                if (emp.gender == "Female" || emp.gender == "female")
                {
                    if (emp.no_of_children == 0)
                    {
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No.of Women with out allowance - " + count);

            }
            else
            {
                Console.WriteLine("No.of Women with out allowance - " + count);
            }

        }
        public void Show_Emp_With_Child(int n)
        {
            int flag = 0;
            foreach (Employee emp in list)
            {

                if (emp.no_of_children < n)
                {
                    flag = 1;
                    Console.WriteLine("Code - {0}  , Name - {1} , DateOfBirth - {2} , Gender - {3} NoOfChildrens - {4} Salary - {5}",
                            emp.code, emp.name, emp.date_of_birth, emp.gender, emp.no_of_children, emp.salary);

                }

            }
            if (flag == 0)
            {
                Console.WriteLine("There is no emp lessthan {0} children", n);
            }
            else
            {
                Console.WriteLine("This is the List of Emp");
            }

        }
        public void SortBySalary()
        {
            var employeesList = list.Cast<Employee>().OrderBy(p => p.salary).ToList();

            foreach (Employee emp in employeesList)
            {
                if (emp.gender == "Male" || emp.gender == "male")
                {
                    Console.WriteLine("Code - {0}  , Name - {1} , DateOfBirth - {2} , Gender - {3} NoOfChildrens - {4} Salary - {5}",
                            emp.code, emp.name, emp.date_of_birth, emp.gender, emp.no_of_children, emp.salary);
                }
            }

        }
        public void Delete(int n)
        {
            foreach (Employee emp in list)
            {
                if (emp.no_of_children > n)
                {
                    if (emp.gender == "Male" || emp.gender == "male")
                    {
                        Console.WriteLine("Code - {0}  , Name - {1} , DateOfBirth - {2} , Gender - {3} NoOfChildrens - {4} Salary - {5}",
                                emp.code, emp.name, emp.date_of_birth, emp.gender, emp.no_of_children, emp.salary);
                        list.Remove(emp);
                    }
                }
                else
                {
                    Console.WriteLine("Code - {0}  , Name - {1} , DateOfBirth - {2} , Gender - {3} NoOfChildrens - {4} Salary - {5}",
                                emp.code, emp.name, emp.date_of_birth, emp.gender, emp.no_of_children, emp.salary);
                }

            }


        }
        public void ShowByName(string name)
        {
            int flag = 0;
            foreach (Employee emp in list)
            {
                if (emp.name == name)
                {
                    Console.WriteLine("Code - {0}  , Name - {1} , DateOfBirth - {2} , Gender - {3} NoOfChildrens - {4} Salary - {5}",
                            emp.code, emp.name, emp.date_of_birth, emp.gender, emp.no_of_children, emp.salary);
                }
            }

        }
        public void UpdateSalary()
        {
            foreach (Employee emp in list)
            {
                int age = DateTime.Now.Year - emp.date_of_birth.Year;
                if (age < 30)
                {
                    emp.salary = emp.salary + (emp.salary * 5) / 100;
                }
                else if (age > 30 && age < 40)
                {
                    emp.salary = emp.salary + (emp.salary * 10) / 100;


                }
                else
                {
                    emp.salary = emp.salary + (emp.salary * 15) / 100;

                }
            }

        }

    }

}
