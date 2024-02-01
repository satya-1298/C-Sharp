using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    public class Multiplayers
    {
        List<Players> _players=new List<Players>();
        
        public void SLPlayers(int noofPlayers)
        {
            for (int i = 1; i <= noofPlayers; i++)
            {
                Players p = new Players();

                Console.WriteLine("Enter the {0} Player Name", i);
                p.Name = Console.ReadLine();
                p.Position = 0;
                _players.Add(p);
            }

        }
        public void SLGame(int WinningPosition)
        {
            int count = 0;
            Random random = new Random();
            
            while (_players.Any(p => p.Position < WinningPosition))
            {
                foreach (var player in _players)
                {
                    //Console.WriteLine("Roll the Dice");
                    //Console.ReadLine();
                    int diceRoll = random.Next(1, 7);
                    Console.WriteLine("\n");

                    Console.WriteLine(" {0} Player rolled Dice {1} ", player.Name, diceRoll);
                    count++;
                    if (player.Position + diceRoll <= WinningPosition)
                    {
                        player.Position += diceRoll;

                        if (player.Position == 28)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}" ,player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Snake !!!!");
                            Console.WriteLine("........................................");
                            player.Position = 10;
                        }
                        else if (player.Position == 37)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}", player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Snake !!!!");
                            Console.WriteLine("........................................");
                            player.Position = 3;
                        }
                        else if (player.Position == 47)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}", player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Snake !!!!");
                            Console.WriteLine("........................................");
                            player.Position = 16;
                        }
                        else if (player.Position == 77)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}", player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Snake !!!!");
                            Console.WriteLine("........................................");
                            player.Position = 32;
                        }
                        else if (player.Position == 94)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}", player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Snake !!!!");
                            Console.WriteLine("........................................");
                            player.Position = 71;
                        }
                        else if (player.Position == 96)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}", player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Snake !!!!");
                            Console.WriteLine("........................................");
                            player.Position = 42;
                        }
                        else if (player.Position == 4)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}", player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Laddder !!!!!");
                            Console.WriteLine("........................................");
                            player.Position = 56;
                        }
                        else if (player.Position == 12)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}", player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Laddder !!!!!");
                            Console.WriteLine("........................................");
                            player.Position = 50;
                        }
                        else if (player.Position == 14)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}", player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Laddder !!!!!");
                            Console.WriteLine("........................................");
                            player.Position = 55;
                        }
                        else if (player.Position == 22)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}", player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Laddder !!!!!");
                            Console.WriteLine("........................................");
                            player.Position = 58;
                        }
                        else if (player.Position == 41)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}", player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Laddder !!!!!");
                            Console.WriteLine("........................................");
                            player.Position = 79;
                        }
                        else if (player.Position == 54)
                        {
                            Console.WriteLine("The Position of the player {0} is - {1}", player.Name, player.Position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Laddder !!!!!");
                            Console.WriteLine("........................................");
                            player.Position = 88;
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("{0} position will remain unchanged.",player.Name);
                    }
                    if (player.Position == WinningPosition)
                    {
                        Console.WriteLine(" {0} won the game ", player.Name);

                        Console.WriteLine("The no. of Times the dice rolled - " + count);
                        return;
                    }
                    Console.WriteLine("{0} position - {1}:",player.Name,player.Position);
                   
                }

            }
        }
    }
}
