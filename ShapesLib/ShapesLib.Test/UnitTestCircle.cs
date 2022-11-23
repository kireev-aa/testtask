namespace ShapesLib.Test
{
    public class UnitTestCircle
    {
        [Fact]
        public void Circle_CheckArea()
        {
            var circle = new Circle(10);

            Assert.Equal(314.15926535897933, circle.Area);
        }
    }
}
