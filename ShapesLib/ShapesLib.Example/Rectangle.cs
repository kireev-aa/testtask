namespace ShapesLib.Example
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    internal class Rectangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        public Rectangle(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }
        public double Area => _sideA * _sideB;

        public override string ToString()
        {
            return $"{nameof(Rectangle)} SideA:{_sideA} SideB:{_sideB}";
        }

    }
}
