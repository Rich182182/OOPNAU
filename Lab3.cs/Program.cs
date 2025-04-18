

namespace Lab3
{
    class Program
    {
        public static void Play(Square obj)
        {
            Square my = new Square();
            my.x = 65;
            obj = my;
        }
        static void Main()
        {
            Console.Write("Enter square origin and side length (x y side): ");
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            double side = double.Parse(input[2]);
            new Square obj;
            Square square1 = new Square();
            Play(square1);
            Square square2 = new Square(square1);
            Square square3 = new Square(2, 2);
            var per1 = square1.GetPerimeter();
            square3 = new Square(square3.x, square3.y, square3.side + 5);
            Square square4 = square2 + square3;

            Console.WriteLine("Square1:");
            Console.WriteLine(square1);
            Console.WriteLine("Square2:");
            Console.WriteLine(square2);
            Console.WriteLine("Square3:");
            Console.WriteLine(square3);
            Console.WriteLine("Square4:");
            Console.WriteLine(square4);
        }
    }
}
