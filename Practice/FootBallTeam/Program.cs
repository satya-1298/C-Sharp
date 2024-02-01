namespace FootBallTeam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Player player = new Player();
           // MainClass mainClass = new MainClass();

            IManager manager= new MainClass();
            var coaches = new List<Coaches>
            {
                new Coaches{code=1,name="Manash",address="Hyderbad",salary=50000,position="Coach",experience=15},
                new Coaches{code=2,name="Surya",address="Kolkata",salary=45000,position="SecondCoach",experience=1},
                new Coaches{code=2,name="Surya",address="Kolkata",salary=15600,position="SecondCoach",experience=3},
                new Coaches{code=2,name="Surya",address="Kolkata",salary=95000,position="SecondCoach",experience=3}

            };
            while (true)
            {

                Console.WriteLine("1-Get all Players");
                Console.WriteLine("2-get all Coaches");
                Console.WriteLine("3-Change the info of player");
                Console.WriteLine("4-Count coaches who experience is greater than 3");
                Console.WriteLine("5-sum the salary of player based on position");
                Console.WriteLine("6-Max salary of the player");
                Console.WriteLine("7-order by player based on shirtNo");
                Console.WriteLine("8-Desending of coaches which experience is = 3 based on salary");
                Console.WriteLine("Enter a option");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Enter size of List ");
                        int size = Convert.ToInt32(Console.ReadLine());
                        manager.Inputplayers(size);
                        manager.GetPlayers();
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("-------------------------------------");
                        manager.Inputcoaches(coaches);
                        manager.GetCoaches();
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("-------------------------------------");
                        int shirtNo =0;
                        double salary=0;
                       
                        Console.Write("Enter Player Code: ");
                        int playerCode = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Option (0 for Shirt Number, 1 for Salary): ");
                        int options = Convert.ToInt32(Console.ReadLine());
                        
                        if(options==0)
                        {
                            Console.Write("Enter New shirtNumber: ");
                            shirtNo = Convert.ToInt32(Console.ReadLine());
                        }
                        else if(options==1) 
                        {
                            Console.Write("Enter New Salary");
                            salary= Convert.ToDouble(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("The code is not present in list");
                        }
                        manager.ChangePlayer(playerCode, options,shirtNo,salary);
                        manager.GetPlayers();
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("-------------------------------------");
                        manager.Inputcoaches(coaches);
                        manager.CountCoaches();
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 5:
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Enter the position");
                        string position=Console.ReadLine();
                        manager.SumSalary_Player(position);
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 6:
                        Console.WriteLine("-------------------------------------");
                        manager.Max_Salary();
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 7:
                        Console.WriteLine("-------------------------------------");
                        manager.Sort_Asc_shirtNo();
                        Console.WriteLine("-------------------------------------");
                        break;
                    case 8:
                        Console.WriteLine("-------------------------------------");
                        manager.Inputcoaches(coaches);
                        manager.Sort_Desc_salary(3);
                        Console.WriteLine("-------------------------------------");
                        break;

                }
            }
           
            
        }
    }
}