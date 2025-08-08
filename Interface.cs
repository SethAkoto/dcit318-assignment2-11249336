using System;

// Interface
interface IMovable
{
    void Move();
}

// Class implementing IMovable: Car
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Class implementing IMovable: Bicycle
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();       
        bicycle.Move();   
    }
}
