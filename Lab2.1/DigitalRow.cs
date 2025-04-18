// DigitalRow.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    public class DigitalRow : Row
    {
        public DigitalRow() : base() { }

        public DigitalRow(string value) : base(value) { }

        public DigitalRow(DigitalRow other) : base(other) { }

        public int CalculateDigitalSum()
        {
            return value.Where(c => char.IsDigit(c))
                        .Sum(c => c - '0');
        }

        public List<int> GetDigits()
        {
            return value.Where(c => char.IsDigit(c))
                        .Select(c => c - '0')
                        .ToList();
        }

        public override string ToString()
        {
            return $"Digital{base.ToString()}, Digital Sum: {CalculateDigitalSum()}";
        }
    }
}
