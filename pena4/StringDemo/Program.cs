namespace StringDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int val = 65;
            Console.WriteLine((char)val);
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;//font colors
                    //Console.Title = "Understanding Console Class";
                    //Console.CursorSize = 100;
                    Console.WriteLine();
                    Console.WriteLine("Enter your choice");
                    //int choice = Convert.ToInt32(Console.ReadLine());
                    int.TryParse(Console.ReadLine(),  out int choice);
                    Console.Beep();
                    switch (choice)
                    {
                        case 1:
                            StringIndex stringIndex = new StringIndex();
                            Console.WriteLine(stringIndex.Index());
                            //stringIndex.Index();
                            break;
                        case 2:
                            Remove remove = new Remove();
                            Console.WriteLine(remove.Removestring(1));
                            break;
                        case 3:
                            Casting casting = new Casting();
                            casting.Conversion();
                            //Console.Clear();
                            break;
                    }
                }
            }
            catch (FormatException fx)
            {
               Console.WriteLine(fx.Message);
            }
        }
    }
}