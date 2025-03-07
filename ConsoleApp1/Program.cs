public class Program
{
    public static void Main(string[] args)
    {
        int num1 = 30;
        int num2 = 20;
        Test(out num1, ref num2);
    }
    public static void Test(out int num1, ref int num2)
    {
        num1 = 40;
        num2 = 30;
        Console.WriteLine(num1 + " " + num2);
    }
    
}