using System;
using ShapeAreaCalculator;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(1f, 2f, 4f);
            var triangleArea = triangle as IShapeArea;

            var triangle2 = new Triangle(3f, 4f, 5f);
            var triangleArea2 = triangle2 as IShapeArea;

            var triangle3 = new Triangle(6f, 4f, 5f);
            var triangleArea3 = triangle3 as IShapeArea;

            var circle = new Circle(5f);
            var circleArea = circle as IShapeArea;

            //with runtime defined figure
            dynamic figure = new System.Dynamic.ExpandoObject();
            var rndValue = (new Random()).Next(0, 100);
            if (rndValue % 2 == 0)
            {
                figure = triangleArea3;
            }
            else
            {
                figure = circleArea;
            }

            Console.WriteLine($"Triangle with sides: {triangle.SideA}, {triangle.SideB}, {triangle.SideC} " +
                $"is {(triangle.IsValid ? "valid" : "not valid")}, " +
                $"is {(triangle.IsRightTriangle() ? "right" : "not right")}" +
                $" and have area: {triangleArea.Area()}");

            Console.WriteLine($"Triangle with sides: {triangle2.SideA}, {triangle2.SideB}, {triangle2.SideC} " +
                $"is {(triangle2.IsValid ? "valid" : "not valid")}, " +
                $"is {(triangle2.IsRightTriangle() ? "right" : "not right")}" +
                $" and have area: {triangleArea2.Area()}");

            Console.WriteLine($"Triangle with sides: {triangle3.SideA}, {triangle3.SideB}, {triangle3.SideC} " +
                $"is {(triangle3.IsValid ? "valid" : "not valid")}, " +
                $"is {(triangle3.IsRightTriangle() ? "right" : "not right")}" +
                $" and have area: {triangleArea3.Area()}");

            Console.WriteLine($"Circle with radius: {circle.Radius} " +
                $"have area: {circleArea.Area()}");

            Console.WriteLine($"figure is: {figure.GetType()}");
            Console.WriteLine($"figure area: {figure.Area()}");

            Console.ReadLine();
        }
    }
}
