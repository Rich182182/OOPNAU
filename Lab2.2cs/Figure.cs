using System;

namespace Lab2_2
{
    public abstract class Figure
    {
        private string _name;

        public string Name
        {
            get { return _name; }
        }

        public Figure()
        {
            _name = "Unknown Figure";
        }

        public Figure(string name)
        {
            _name = name;
        }

        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual double CalculatePerimeter()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Figure: {_name}";
        }
    }
}
