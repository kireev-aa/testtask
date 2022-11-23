namespace ShapesLib.Example
{
    class Program
    {
        static void Main()
        {
            var circle = new Circle(15);
            Console.WriteLine($"{circle} Area:{circle.Area}");

            var triangle = new Triangle(10, 10, 15);
            Console.WriteLine($"{triangle} Area:{triangle.Area} IsRightabout:{triangle.IsRightabout}");

            var triangleRigh = new Triangle(3, 3, 4.2426406);
            Console.WriteLine($"{triangleRigh} Area:{triangleRigh.Area} IsRightabout:{triangleRigh.IsRightabout}");

            var rectangle = new Rectangle(10, 15);
            Console.WriteLine($"{rectangle} Area:{rectangle.Area}");

            var sumArea = SumArea(new List<IShape>() { circle, triangle, rectangle });

            Console.WriteLine($"SumArea:{sumArea}");
        }

        static double SumArea(IEnumerable<IShape> shapes)
        {
            return shapes.Sum(shape => shape.Area);
        }
    }
}