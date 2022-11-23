using System;

namespace ShapesLib
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double Area
        {
            get
            {
                var p = (_sideA + _sideB + _sideC) / 2;
                return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            }
        }

        public bool IsRightabout
        {
            get
            {
                return Math.Round(Math.Pow(_sideC, 2), 5) == Math.Round(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2), 5)
                    || Math.Round(Math.Pow(_sideA, 2), 5) == Math.Round(Math.Pow(_sideC, 2) + Math.Pow(_sideB, 2), 5)
                    || Math.Round(Math.Pow(_sideB, 2), 5) == Math.Round(Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2), 5);
            }
        }

        public override string ToString()
        {
            return $"{nameof(Triangle)} SideA:{_sideA} SideB:{_sideB} SideC:{_sideC}";
        }
    }
}
