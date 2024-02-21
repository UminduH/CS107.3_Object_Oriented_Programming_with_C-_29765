using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_04
{
    public class Shape
    {
        protected string shapeType;
        protected double area;

        public void CalculateArea(double val1, double val2)
        {
            area = val1 * val2;
        }

        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Type: {shapeType}");
            Console.WriteLine($"Area: {area}");
        }

        public Shape()
        {
            shapeType = "Default Shape";
            area = 0;
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public void SetDimensions(double length, double width )
        {
            this.length = length;
            this.width = width;

            shapeType = "Rectangle";
            CalculateArea(length, width);
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo();
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public void SetRadius(double radius)
        {
            this.radius = radius;
            shapeType = "Circle";
            CalculateArea(radius, radius);
            area *= Math.PI;
            area = Math.Round(area, 2);
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo();
            Console.WriteLine($"Radius: {radius}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetDimensions(5, 3);
            rectangle.DisplayShapeInfo();

            Console.WriteLine();

            Circle circle = new Circle();
            circle.SetRadius(4);
            circle.DisplayShapeInfo();

            Console.ReadLine();
        }
    }
}
