namespace Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Your choice");
                Console.WriteLine("1--Stack Using Queue");
                Console.WriteLine("2--Find First Unique char in string");
                Console.WriteLine("3--Length Of Last Word");
                Console.WriteLine("4--Sum Two array Elements ");
                Console.WriteLine("5--Fibonacci");
                Console.WriteLine("6--Queue Using Stack");
                Console.WriteLine("7--Climbing Stairs in Different ways");
                Console.WriteLine("8--Inbuilt List merging");
                Console.WriteLine("9--Search element in array");
                Console.WriteLine("10--Exit");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                        MyStack queue = new MyStack();
                        queue.Push(2);
                        queue.Push(3);
                        queue.Push(4);
                        queue.Pop();
                        queue.Top();
                        queue.Empty();
                        break;
                    case 2: 
                        StringUnique stringUnique=new StringUnique();
                        stringUnique.Find("Satya");
                        break;
                    case 3: 
                        LengthOfLastWord length=new LengthOfLastWord();
                        length.Word("Hello Satya");
                        break;
                    case 4:
                        TwoSumArray twoSumArray=new TwoSumArray();
                       // int[] arr1 = null; 
                        int[] arr1 = { 1, 3, 4, 5 };
                        twoSumArray.TwoSum(arr1,9);
                        break;
                    case 5:
                        Fibbanocci fibbanocci = new Fibbanocci();
                        int val=fibbanocci.Fib(-6);
                        Console.WriteLine(val); 
                        break;
                    case 6:
                        QueueUsingStack queueUsingStack = new QueueUsingStack();
                        queueUsingStack.Push(1);
                        //queueUsingStack.Push(2);
                        //queueUsingStack.Push(3);
                        Console.WriteLine(queueUsingStack.Pop());
                        Console.WriteLine(queueUsingStack.Peek());
                        Console.WriteLine(queueUsingStack.Empty());
                        break;
                case 7:
                    ClimbStair climbStair = new ClimbStair();
                        Console.WriteLine(climbStair.ClimbStairs(5));
                        break;
                    case 8:
                        MergeList mergeList = new MergeList();
                        mergeList.values();
                        break;
                    case 9:
                        Search search = new Search();
                        search.Element(3);
                        break;
                    case 10:
                        flag = false;
                        break;
                }
            }
        }
    }
}