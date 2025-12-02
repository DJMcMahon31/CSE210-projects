using System;

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Length { get; set; }

    public Rectangle(double width, double length, string color)
    {
        Width = width;
        Length = length;
        Color = color;
    }

    public override double GetArea()
    {
        return Width * Length;
    }

}


//PURPOSE OF Rectangle.cs
//inherits from Shape.cs, must override 'GetArea()', must store two measurements (width and height), uses the inherited 'Color' property

//CLASS DEFINITION - establish inheritance
//  public class Rectangle : Shape {}
//Rectangle is a Shape, gets 'Color' from Shape, required to implement 'GetArea()

//ADD Rectangle-SPECIFIC PROPERTIES - needs Width and Length
//  public double Width { get; set; }  public double Length { get; set; }

//ADD A CONSTRUCTOR TO RECEIVE WIDTH/LENGTH/COLOR
//  public Rectangle(double width, double length, string color) {Width = width; Length = length; Color = color;}

//IMPLEMENT GetArea()  required by Shape
//  public abstract double GetArea();  
//  Override:  public override double GetArea() {return Width * Length;} 

//COMPLETE Rectangle.cs FILE
//