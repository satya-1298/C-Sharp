namespace Demo;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            //Fact fact = new Fact();
            //fact.value();
            //OddEven oddEven = new OddEven();
            //oddEven.Number();
            //ListDemo listDemo = new ListDemo();
            // listDemo.values();
            //int[] nums = { 1, 2, 3 };
            //int target=5;
            //ArrayDemo arrayDemo = new ArrayDemo();
            //arrayDemo.TwoSum(nums, target);
            //LinkedList linkedList = new LinkedList();
            //linkedList.Add(1);
            //linkedList.Add(2);
            //linkedList.Add(3);
            //Console.WriteLine(MethodExtension.method("Satya"));
            //string s = "Satya";
            //Console.WriteLine(s.method());
            //Unique unique = new Unique();
            //unique.FirstUniqChar("leetcolde");
            Lengthoflast lengthoflast = new Lengthoflast();
            lengthoflast.LengthOfLastWord("Hello Satya i");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}