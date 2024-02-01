using Snake_and_Ladder;

namespace Snake_And_Ladder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OnePlayer onePlayer = new OnePlayer();
            onePlayer.Game();

            Multiplayers multiplayers = new Multiplayers();
            Console.WriteLine("Enter number of players");
            int n = Convert.ToInt32(Console.ReadLine());
            multiplayers.SLPlayers(n);
            multiplayers.SLGame(100);

        }
    }
}