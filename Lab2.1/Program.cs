// Program.cs
using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a row with digits: ");
            string inputRow = Console.ReadLine();

            DigitalRow digitalRow = new DigitalRow(inputRow);

            Console.WriteLine("Row information: ");
            Console.WriteLine(digitalRow);

            Console.Write("Digits in the row: ");
            List<int> digits = digitalRow.GetDigits();
            foreach (int digit in digits)
            {
                Console.Write($"{digit} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Row length: {digitalRow.CalculateLength()}");
            Console.WriteLine($"Digital sum: {digitalRow.CalculateDigitalSum()}");
        }
    }
}
