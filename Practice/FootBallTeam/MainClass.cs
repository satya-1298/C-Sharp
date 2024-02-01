using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBallTeam
{
    public class MainClass : IManager
    {
        List<Player> _players = new List<Player>();
        List<Coaches> _coaches = new List<Coaches>();
        public void Inputplayers(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Player player = new Player();
                Console.WriteLine("---------------Player {0}--------------------", i);
                Console.WriteLine("Enter the code");
                player.code=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name");
                player.name = Console.ReadLine();
                Console.WriteLine("Enter Address");
                player.address = Console.ReadLine();
                Console.WriteLine("Enter Shirt Number");
                player.shirtNumber=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter salary");
                player.salary=Convert.ToInt32(Console.ReadLine());  
                Console.WriteLine("Enter Position");
                player.position = Console.ReadLine();
                _players.Add(player);
            }
        }
        public void GetPlayers()
        {
            foreach (var p in _players)
            {
                Console.WriteLine("Code - {0} , Name - {1} , Address - {2} , ShirtNumber - {3} , Salary - {4} , Position - {5}  ", p.code, p.name, p.address
                                    , p.shirtNumber, p.salary, p.position);
            }

        }
        public void Inputcoaches(List<Coaches> coaches)
        {
            this._coaches = coaches;
        }
        public void GetCoaches()
        {
            foreach (var c in _coaches)
            {
                Console.WriteLine("Code - {0} , Name - {1} , Address - {2} ,  Salary - {3} , Position - {4} , Experience - {5}  ", c.code, c.name, c.address
                                    , c.salary,c.position, c.experience);
            }
        }
        public void ChangePlayer(int code, int option, int shirtNumber, double salary)
        {
          
             var player = _players.FirstOrDefault(p => p.code == code);
            if(player != null)
            {
                if(option== 0)
                {
                    player.shirtNumber = shirtNumber;
                }
                else
                {
                    player.salary = salary;
                }
            }
            
        }
        public void CountCoaches()
        {
            var result=_coaches.Count(p => p.experience < 3);
            if(result != null)
            {
                Console.WriteLine(result);
                if(result == 0)
                {
                    Console.WriteLine("there is no coaches who are less than three years experience");

                }
            }                      
        }
        public void SumSalary_Player(string position)
        {
            double sal=0;
            var result=_players.Count(p => p.position == position);
            if(result != null)
            {
                for(int i = 0;i<result;i++)
                {
                    sal = sal + _players[i].salary;
                }
                Console.WriteLine("the sum of salary for  all {0} are {1} ",position,sal);
            }
        }
        public void Max_Salary()
        {
            //var result = _players.Max(p => p.salary);
            //Console.WriteLine("max_salary: {1}",result);
            var result=_players.OrderByDescending(p => p.salary).FirstOrDefault();
            if(result != null)
            {
                Console.WriteLine("Code-{0}  , salary-{1} ",result.code,result.salary);
            }
        }
        public void Sort_Asc_shirtNo()
        {
            var result = _players.OrderBy(p => p.shirtNumber).ToList();
          
            foreach(var p in result)
            {
                Console.WriteLine("Code - {0} , Name - {1} , Address - {2} , ShirtNumber - {3} , Salary - {4} , Position - {5}  ", p.code, p.name, p.address
                                    , p.shirtNumber, p.salary, p.position);
            }
          
        }
        public void Sort_Desc_salary(int experience)
        {
            var result=_coaches.Where(p=>p.experience == experience).ToList();
            if(result != null)
            {
                var val=result.OrderByDescending(p => p.salary).ToList();
                foreach (var c in val)
                {
                    Console.WriteLine("Code - {0} , Name - {1} , Address - {2} ,  Salary - {3} , Position - {4} , Experience - {5}  ", c.code, c.name, c.address
                                        , c.salary, c.position, c.experience);
                }

            }
        }
    }
}
