using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometryShape
{
    public class Triangle
    {
        public double SideA {  get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double Perimeter ()
        {
            return SideA + SideB + SideC;
        }
        public double Area ()
        {
            return Math.Sqrt((Perimeter() / 2) * ((Perimeter() / 2) - SideA) * ((Perimeter() / 2) - SideB) * ((Perimeter() / 2) - SideC));
        }
        public string ToString ()
        {
            return $"Треугольник: Первая сторона = {SideA}, Вторая сторона = {SideB}, Третья сторона = {SideC},\n Периметр = {Perimeter()} , Площадь = {Area()}";
        }
       
        public string CheckingTheCorrectnes()
        {
            if(SideA+SideB<=SideC)
            {
                return "Такой треугольник не может существовать";
            }
            if (SideA + SideC <= SideB)
            {
                return "Такой треугольник не может существовать";
            }
            if (SideC + SideB <= SideB)
            {
                return "Такой треугольник не может существовать";
            }
            return null;
        }

    }
}
