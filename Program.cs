using NUnit.Framework;

[TestFixture]
public class AreaCalculatorTests
{
    [Test]
    public void CalculateSquareArea_ValidSideLength_ReturnsCorrectArea()
    {
        // Arrange
        double sideLength = 5;
        Square square = new Square(sideLength);

        // Act
        double area = square.Area();

        // Assert
        Assert.AreEqual(25, area);
    }

    [Test]
    public void CalculateTriangleArea_ValidBaseAndHeight_ReturnsCorrectArea()
    {
        // Arrange
        double @base = 6;
        double height = 4;
        Triangle triangle = new Triangle(@base, height);

        // Act
        double area = triangle.Area();

        // Assert
        Assert.AreEqual(12, area);
    }

    [Test]
    public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
    {
        // Arrange
        double radius = 3;
        Circle circle = new Circle(radius);

        // Act
        double area = circle.Area();

        // Assert
        Assert.AreEqual(Math.PI * radius * radius, area);
    }
}

using System;

public class Square
{
    private readonly double sideLength;

    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public double Area()
    {
        return sideLength * sideLength;
    }
}

public class Triangle
{
    private readonly double @base;
    private readonly double height;

    public Triangle(double @base, double height)
    {
        this.@base = @base;
        this.height = height;
    }

    public double Area()
    {
        return 0.5 * @base * height;
    }
}

public class Circle
{
    private readonly double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }
}

public static class AreaCalculator
{
    public static double CalculateSquareArea(double sideLength)
    {
        return sideLength * sideLength;
    }

    public static double CalculateTriangleArea(double @base, double height)
    {
        return 0.5 * @base * height;
    }

    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}
