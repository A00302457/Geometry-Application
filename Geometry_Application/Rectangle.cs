using System.Dynamic;

namespace Geometry_Application;
public class Rectangle : IShape
{

    public double _height;
    public double _width;
     public Rectangle(){

    }
    public double height
    {
        get{ return _height;}
        set{ _height = height;}
    }
    public double width
    {
        get{ return _width;}
        set { _width = width;}
    }
   
    public double CalculateArea()
    {
        return _height * _width;
    }
    public double CalculatePerimeter()
    {
        return 2 * (_height + _width);
    }

}