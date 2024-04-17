using System.Dynamic;

namespace Geometry_Application;
public class Triangle : IShape
{
   public double _side1;
    public double _side2;
    public double _side3;
    public double side1
    {
        get{ return _side1;}
        set{ _side1 = side1;}
    }
    public double side2
    {
        get{ return _side2;}
        set{ _side2 = side2;}
    }
    public double side3
    {
        get{ return _side3;}
        set{ _side3 = side3;}
    }
    public Triangle(){

    }
    public double CalculateArea()
    {
        return (_side1 * _side2 * _side3) / 2;
    }
    public double CalculatePerimeter()
    {
        return _side1 + _side2 + _side3;
    }

}