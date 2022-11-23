using System;

namespace ShapesLib
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area => Math.PI * Math.Pow(_radius, 2);

        public override string ToString()
        {
            return $"{nameof(Circle)} Radius:{_radius}";
        }
    }
}
