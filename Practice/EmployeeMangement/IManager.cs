using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement
{
    public interface IManager
    {
        public void InputList(int size);
        public void ShowList();
        //allowance is 0
        public void FemaleEmpCount();
        public void Show_Emp_With_Child(int n);
        public void SortBySalary();
        public void Delete(int n);
        public void ShowByName(string name);
        public void UpdateSalary();

    }
}
