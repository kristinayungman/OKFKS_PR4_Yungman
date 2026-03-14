using GeometryShape;

namespace TestRectangle
{
    public class TestRestang
    {
        const int Areaa = 42;
        const int Perimetrr = 26;
        [Fact]
        public void RectangleCorrectArea ()
        {
            Rectangle rectangle = new Rectangle(6, 7);
            Assert.Equal(Areaa, rectangle.Area());
        }
        [Fact]
        public void RectangleCorrectPerimeter ()
        {
            Rectangle rectangle = new Rectangle(6, 7);
            Assert.Equal(Perimetrr, rectangle.Perimeter());
        }
        [Theory]
        [InlineData(-5, 10)]
        [InlineData(0, 2)]
        [InlineData(-5, -10)]
        public void Reastangle_ThrowsArgumentException(double width, double height)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(width, height));
        }
        [Fact]
        public void Restangle_String()
        {
            Rectangle rectangle = new Rectangle(6, 7);
            //string expected = "Прямоугольник: Ширина = 6, Высота = 7, Площадь = 42, Периметр = 26";
            string result = rectangle.ToString();
            Assert.Contains("= 6,", result);
            Assert.Contains("= 7,", result);
            Assert.Contains("= 42,", result);
            Assert.Contains("= 26", result);
            Assert.StartsWith("Прямоугольник:", result);
        }
    }
}