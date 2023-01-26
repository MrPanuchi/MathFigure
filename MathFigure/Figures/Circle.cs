using System;

namespace MathFigure.Figures
{
    public class Circle : Figure
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0) throw new ArgumentException($"Radius = {value} but must be greater than 0");
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
