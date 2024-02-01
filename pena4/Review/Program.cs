namespace Review
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Frequency frequency = new Frequency();
            //Dictionary<char, int> result = frequency.CountElement("sai sai satya");

            //foreach (var pair in result)
            //{
            //    Console.WriteLine($"Character: {pair.Key}, Frequency: {pair.Value}");
            //}
            //Frequency2 frequency2 = new Frequency2();
            //Console.WriteLine(frequency2.Normal("Sai Satyasss"));
            Frequency3 frequency3 = new Frequency3();
            Console.WriteLine(frequency3.Elements("Hello"));
            //frequency3.Elements("Hello");
        }
    }
}