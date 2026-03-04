using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

    

     public double Area ()
        {
            return Width * Height;
        }

        public double Perimeter ()
        {
            return 2 * (Width + Height);
        }

        public string ToString ()
        {
            return $"Прямоугольник: Ширина = {Width}, Высота = {Height}, Площадь = {Area()}, Периметр = {Perimeter()}";
        }



    }
}
