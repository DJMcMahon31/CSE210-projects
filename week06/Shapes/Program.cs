using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        //add shapes to the list
        shapes.Add(new Square(4, "Red"));
        shapes.Add(new Rectangle(3, 5, "Green"));
        shapes.Add(new Circle(2,"Blue"));

        //display information about each shape
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Shape Type: {s.GetType().Name}");
            Console.WriteLine($"Shape Color: {s.Color}");
            Console.WriteLine($"Shape Area: {s.GetArea()}");
            Console.WriteLine();
        }
    }
}



//CREATE A LIST THAT CAN STORE ANY SHAPE
//  List<Shape> shapes = new List<Shape>();

//ADD DIFFERENT SHAPES TO THE LIST
//  shapes.Add(new Square(4, "Red"));
//  shapes.Add(new Rectangle(3, 5, "Blue"));
//  shapes.Add(new Circle(2,"Green"));
   //even though they are different classes, they all go into the same List<Shape>

//LOOP THROUGH THE LIST OF SHAPES
//  foreach (Shape s in shapes)
//  { Console.WriteLine($"Color: {s.Color}"; Console.WriteLine($"Area: {s.GetArea()}"); }
// -- breakdown of the polymorphism: the variable 's' is typed as Shape; the actual object may be: Square, Rectangle, or Circle; when calling 's.GetArea()' C# automatically chooses the correct override.

//WAYS TO SHOW WHICH SHAPE IS BEING REFERRED TO:
//OPTION # 1 - USE 'GetType().Name'  -- easiest and most common
  //Console.WriteLine($"Shape Type: {s.GetType().Name}");
  //Console.WriteLine($"Color: {s.Color}");
  //Console.WriteLine($"Area: {s.GetArea()}");
  //Console.WriteLine();

//OPTION # 2 - ADD A METHOD TO THE BASE CLASS (GetName or GetShapeType)
  //In Shape.cs:
  //public string GetShapeName()
  //{
      //return GetType().Name;
  //}
  //In Program.cs:
  //Console.WriteLine($"Shape Type: {s.GetShapeName()}");
  //Console.WriteLine($"Color: {s.Color}");
  //Console.WriteLine($"Area: {s.GetArea()}");
  //Console.WriteLine();
    //this keeps the naming logic inside the object instead of the program

//OPTION # 3 - ADD A VIRTUAL OR ABSTRACT METHOD SO EACH SHAPE CAN PROVIDE ITS OWN NAME
  //In Shape.cs:
   //public abstract string GetName();
  //In Square.cs:
   //public override string GetName()
   // {
        //return "Square";
   // } 
  //In Rectangle.cs:
    //public override string GetName()
    //{
    //    return "Rectangle";
    //} 
  //In Circle.cs:
    //public override string GetName()
    //{
        //return "Circle";
    //}
  //In Program.cs:
    //Console.WriteLineI$"Shape Type: {s.GetName()"};


//could also be written this way:
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
*/

 


