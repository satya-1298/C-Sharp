using System.Drawing;

namespace EmployeeMangement
{
    public class Program
    {
       
        public static void Main(string[] args) 
        {
            IManager manager = new Manager();
            
            while (true)
            {
                Console.WriteLine("1-Input Employees");
                Console.WriteLine("2-Show List of Employee");
                Console.WriteLine("3-Count Females who don't have allowance ");
                Console.WriteLine("4-Display emp who have < n childrens");
                Console.WriteLine("5-Display Male emp in ascending order");
                Console.WriteLine("6-Removing male employees according to the number of entries");
                Console.WriteLine("7-Display employees by name");
                Console.WriteLine("8-Update Salary");
                Console.WriteLine("Enter option");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option) 
                {
                    case 1:
                        Console.WriteLine("Enter the list size");
                        int size = Convert.ToInt32(Console.ReadLine());
                        manager.InputList(size);
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        manager.ShowList();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        manager.FemaleEmpCount();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Console.WriteLine("Enter a value");
                        int n = Convert.ToInt32(Console.ReadLine());
                        manager.Show_Emp_With_Child(n);
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        manager.SortBySalary();
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        Console.WriteLine("Enter a value");
                        int num = Convert.ToInt32(Console.ReadLine());
                        manager.Delete(num);
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        Console.WriteLine("Enter the name");
                        string name= Console.ReadLine();
                        manager.ShowByName(name);
                        Console.WriteLine("\n");
                        break;
                    case 8:
                        manager.UpdateSalary();
                        Console.WriteLine("\n");
                        break;
                     default:
                        Console.WriteLine("Entered Invalid option ");
                        break;


                }
            }
        }
    }
}