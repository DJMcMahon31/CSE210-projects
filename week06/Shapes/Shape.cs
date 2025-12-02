using System;

public abstract class Shape
{    
    public string Color { get; set; }  //base class does not need a constructor in this case. The derived classes handle the color assignment
    //a base constructor is only needed when the base class needs to force certain data at creation, or the derived classes rely on shared initialization logic
    //Color can be set: after the object is created; inside the derived class constructor; by the user.

    //e.g. 'private string _color' is not needed because the auto-properties have already stored this internally
    //e.g. 'public Shape(string color' is not needed because derived classes already receive and set the color
    //e.g. '_color = color' is not needed because the Auto-property setter(Color = color) already handles the assignment

    public abstract double GetArea();

}

//The code could also look like this as per the sample shown in the assignment
/*
public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
        public abstract double GetArea();
}
*/