namespace MathFigure.Figures
{
    public abstract class Figure : IPerimeter, IArea
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}
