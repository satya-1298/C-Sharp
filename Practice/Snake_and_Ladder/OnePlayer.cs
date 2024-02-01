using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    public class OnePlayer
    {
        public void Game()
        {
            int winning_Position = 100;
            int count = 0;
            int position = 0;
            int diceRoll;
            while(position<winning_Position)
            {
                Random random = new Random();
                diceRoll = random.Next(1,7);
                Console.WriteLine(diceRoll);
                if(position+diceRoll<=winning_Position )
                {

                    position = position + diceRoll;
                    Dictionary<int, int> snake = new Dictionary<int, int>();
                    snake.Add(28, 10);
                    snake.Add(37, 3);
                    snake.Add(47 , 16);
                    snake.Add(77, 32);
                    snake.Add(96, 42);
                    snake.Add(94, 71);
                    foreach (KeyValuePair<int, int> i in snake)
                    {
                        if (position == i.Key)
                        {
                            Console.WriteLine("The Position of the player is - " + position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Snake !!!!");
                            Console.WriteLine("........................................");
                            position = i.Value;
                        }
                    }
                    Dictionary<int, int> ladder = new Dictionary<int, int>();
                    ladder.Add(4, 56);
                    ladder.Add(12,50);
                    ladder.Add(14, 55);
                    ladder.Add(22, 58);
                    ladder.Add(41, 79);
                    ladder.Add(54, 88);
                    foreach (KeyValuePair<int, int> i in ladder)
                    {
                        if (position == i.Key)
                        {
                            Console.WriteLine("The Position of the player is - " + position);
                            Console.WriteLine("........................................");
                            Console.WriteLine("It is Ladder !!!!");
                            Console.WriteLine("........................................");
                            position = i.Value;
                        }
                    }
                  

                }
                else
                {

                    Console.WriteLine("-------------The Position will be unchanged----------------");
                }
                Console.WriteLine("The Position of the player is - " + position);
                Console.WriteLine("\n");
                if (position == winning_Position)
                {
                    Console.WriteLine("GameOver");
                }
                count++;
            }
          
            Console.WriteLine("The no. of time the dice rolled = "+count);
        }
    }
}
