using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement
{
    public interface IManager
    {
        public void ListOfTeachers();
        public void Teachers_High_Salary();

        public void Slot_PTeachers();
        public void Sort_Salary_Desc();

        public void DisplayName_By_Char();
        
    }
}
