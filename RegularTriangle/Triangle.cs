using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularTriangle
{
    public class Triangle
    {
        // длины сторон
        int a, b, c;

        // конструктор
        public Triangle()
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;
        }

        // конструктор с параметрами
        public Triangle(int a, int b, int c)
        {
                this.a = a;
                this.b = b;
                this.c = c;
        }

        // расчет площади прямоугольного треугольника
        public double Area()
        {
            double area=0;
            try
            {
                // проверка на значение стороны
                if (a <= 0 || b <= 0 || c <= 0)
                    throw new ArgumentException("Значение длины стороны должно быть положительным числом!");
                area = 0.5 * a * b;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            return area;
        }
    }
}
