﻿using System;
using System.Linq;

namespace MathFigure.Figures
{
    public class Triangle : Figure
    {
        private double[] _sides;
        public double[] Sides 
        { 
            get { return _sides; } 
            set 
            {
                int count = value.Length;
                if (count != 3) throw new ArgumentException($"sides.Count = {count} but must be 3");
                if (value.Any(x => x <= 0)) throw new ArgumentException("All side.Lenght must be greater than 0");
                if (value[0] + value[1] <= value[2]) throw new ArgumentException("The sum of the legs is greater than the hypotenuse");
                if (value[2] + value[0] <= value[1]) throw new ArgumentException("The sum of the legs is greater than the hypotenuse");
                if (value[1] + value[2] <= value[0]) throw new ArgumentException("The sum of the legs is greater than the hypotenuse");
                _sides = value;
            }
        }
        public Triangle(double[] sides)
        {
            Sides = sides;
        }
        public override double GetArea()
        {
            double halfp = GetPerimeter() / 2;
            return Math.Sqrt(halfp * (halfp - Sides[0]) * (halfp - Sides[1]) * (halfp - Sides[2]));
        }

        public override double GetPerimeter()
        {
            return Sides.Sum();
        }
        public bool IsRightTriangle()
        {
            double[] sortsides = Sides.OrderBy(x => x).ToArray();
            if (Math.Pow(sortsides[0], 2) + Math.Pow(sortsides[1],2) == Math.Pow(sortsides[2],2))
            {
                return true;
            }
            return false;
        }
    }
}
