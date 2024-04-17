using System.Dynamic;

namespace Geometry_Application;
public class Square : IShape
{
    public double _side;
    //private double _width;
    public double side
    {
        get{ return _side;}
        set{ _side = side;}
    }
    // public double width
    // {
    //     get{ return _width;}
    //     set { _width = width;}
    // }
    public Square(){

    }
    public double CalculateArea()
    {
        return 2 * _side;
    }
    public double CalculatePerimeter()
    {
        return 4 * _side;
    }

}