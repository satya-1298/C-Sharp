using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBallTeam
{
    public interface IManager
    {
        public void Inputplayers(int size);
        public void Inputcoaches(List<Coaches> coaches);
        public void GetPlayers();
        public void GetCoaches();
        public void ChangePlayer(int code, int option, int shirtNumber,double salary);
        public void CountCoaches();
        public void SumSalary_Player(string position);
        public void Max_Salary();
        public void Sort_Asc_shirtNo();
        public void Sort_Desc_salary(int experience); 
        
    }
}
