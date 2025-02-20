using System;


namespace Lab2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter vector endpoint coordinates (x y): ");
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            
            Vector vector = new Vector(x, y);
            Console.WriteLine($"Created vector: {vector}");
            Console.WriteLine($"Vector length: {vector.Length():F2}");
            (double radius, double angle) polar = vector.GetPolarCoordinates();
            Console.WriteLine($"Polar coordinates: Radius = {polar.radius:F2}, Angle = {polar.angle:F2} radians");
        }
    }
}