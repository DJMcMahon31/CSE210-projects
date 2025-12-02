using System;
using System.Drawing;

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}


//PURPOSE OF Circle.cs - inherits from Shape.cs, must override the abstract 'GetArea()' method, needs to store radius, uses the inherited 'Color' property

//START WITH THE CLASS DECLARATION AND INHERITANCE
//  public class Circle : Shape {}
//Circle is a Shape, Circle inherits 'Color', Circle must override 'GetArea()'

//ADD THE RADIUS PROPERTY
//  public double Radius { get; set; }

//ADD A CONSTRUCTOR TO RECEIVE radius + color
//  public Circle(double radius, string color) {radius = radius; Color = color;}
//the constructor sets: 'Radius' (unique to Circle) and 'Color' (inherited from Shape)

//OVERRIDE GetArea()
//  public abstract double GetArea();  //base class defined an abstract method
//  { return Math.PI * Radius * Radius; }


//could also be written this way:
/*
public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}
*/