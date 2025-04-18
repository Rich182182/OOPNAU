// Row.cs
using System;

namespace Lab3
{
    public class Row
    {
        protected string value;

        public string Value
        {
            get { return value; }
        }

        public Row() : this("") { }

        public Row(string value)
        {
            this.value = value;
        }

        public Row(Row other)
        {
            this.value = other.value;
        }

        ~Row()
        {
            Console.WriteLine("Row object is being deleted");
        }

        public int CalculateLength()
        {
            return value.Length;
        }

        public override string ToString()
        {
            return $"Row: {value}, Length: {CalculateLength()}";
        }
    }
}
