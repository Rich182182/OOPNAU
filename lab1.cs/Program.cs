namespace Lab1cs
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Add Coordinates x and y:");
            double x = double.Parse(Console.ReadLine() ?? "0");
            double y = double.Parse(Console.ReadLine() ?? "0");
            Vector v = new Vector(x, y);
            Console.WriteLine(v.PrintCoordinates());
            Console.WriteLine(v.PrintPolarCoordinates());
        }
    }
}