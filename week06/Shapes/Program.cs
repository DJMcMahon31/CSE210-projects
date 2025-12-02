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
