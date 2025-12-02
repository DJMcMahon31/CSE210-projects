using System;
using System.Reflection.Metadata;

public class Square : Shape
{
    public double Side { get; set; }
    public Square(double side, string color)
    {
        Side = side;
        Color = color;  //inherited from Shape.cs
    }

    public override double GetArea()
    {
        return Side * Side;
    }

}


//PURPOSE OF Square.cs
//inherits from Shape.cs
//must provide its own version of GetArea()
//must store whatever information a square needs
//also receives the color from the program (or user) and stores it in the inherited 'Color' property

//CLASS DEFINITION AND INHERITANCE
//  public class Square : Shape
//A Square is a Shape
//A Square must follow Shape's rules
//A Square automatically receives 'Color' and 'GetArea' (to override)

//SQUARE'S UNIQUE ATTRIBUT: SIDE LENGTH
//  public double Side { get; set; }

//ADD A CONSTRUCTOR - accept a side length, accept a color, store both
//  public Square(double side, string color) {Side = side;  Color = color;}

//IMPLEMENT THE REQUIRED ABSTRACT METHOD: GetArea()
//base class has: public abstract double GetArea();
//Square's formula: Area = side x side
//Override: public override double GetArea()  {return Side * Side;}



