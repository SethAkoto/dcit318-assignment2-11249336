using System;

// Abstract class
abstract class Shape
{
    public abstract double GetArea();
}

// Derived class: Circle
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class: Rectangle
class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Shape circle = new Circle(5);        
        Shape rectangle = new Rectangle(4, 6);


        Console.WriteLine("Circle Area: " + circle.GetArea());
        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
    }
}
