using PayrollManagement;

namespace PayrollManageMent
{
    public class Program
    {
        public static void Main(string[] args)

        {
            Manager manager = new Manager();
            manager.ListOfTeachers();
            manager.Teachers_High_Salary();
            manager.Sort_Salary_Desc();
            Console.WriteLine("----------------------------");
            manager.Slot_PTeachers();
            Console.WriteLine("----------------------------");
            manager.DisplayName_By_Char();
        }
    }
}