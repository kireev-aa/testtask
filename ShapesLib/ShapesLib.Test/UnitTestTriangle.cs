namespace ShapesLib.Test
{
    public class UnitTestTriangle
    {
        [Fact]
        public void Triangle_CheckArea()
        {
            var triangle = new Triangle(10, 10, 15);
            Assert.Equal(49.607837082461074, triangle.Area);
        }

        [Fact]
        public void Triangle_CheckRightabout()
        {
            var triangle = new Triangle(3, 3, 4.2426406);
            Assert.True(triangle.IsRightabout);
        }
    }
}
