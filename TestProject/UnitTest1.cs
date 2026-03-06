using GeometryShape;

namespace TestRectangle
{
    public class UnitTest1
    {
        [Fact]
        public void RectangleCorrectArea ()
        {
            Rectangle rectangle = new Rectangle(4, 5);
            Assert.Equal(20, rectangle.Area());
        }
        [Fact]
        public void RectangleCorrectPerimeter ()
        {
            Rectangle rectangle = new Rectangle(4, 5);
            Assert.Equal(18, rectangle.Perimeter());
        }

        [Fact]
        public void RectangleInvalidinput ()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(-4, -5));
        }
    }
}