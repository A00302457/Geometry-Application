using Geometry_Application;

namespace Geometry_Application_Test;

[TestClass]
public class Geometry_Triangle_Test
{
    /////////////////////////////////////////////CalculateArea/////////////////////////////////////////////////
    [TestMethod]
    public void Geometry_Triangle_CalculateArea_Method_Receives_Zeros_And_Return_Zeros()
    {
        var triangle = new Triangle();
        triangle._side1 = 0;
        triangle._side2 = 0;
        triangle._side3 = 0;
        var result = triangle.CalculateArea();
        Assert.AreEqual(0 , result);
    }
    [TestMethod]
    public void Geometry_Triangle_CalculateArea_Method_Receives_one_Negative_side1_Returns_Zero()
    {           
        var triangle = new Triangle();
        triangle._side1 = 0;
        triangle._side2 = 0;
        triangle._side3 = 0;
        var result = triangle.CalculateArea();    
        Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void Geometry_Triangle_CalculateArea_Method_Receives_Number_And_Return_Result()
    {
        var triangle = new Triangle();
        triangle._side1 = 10;
        triangle._side2 = 10;
        triangle._side3 = 10;
        var result = triangle.CalculateArea();    
        Assert.AreEqual(500, result);
    }

    ////////////////////////////////////////////////CalculatePeramiter///////////////////////////////////////////
     [TestMethod]
     public void Geometry_Triangle_CalculatePeramiter_Method_Receives_Zeros_And_Return_Zeros()
    {
        var triangle = new Triangle();
        triangle._side1 = 0;
        triangle._side2 = 0;
        triangle._side3 = 0;
        var result = triangle.CalculatePerimeter();
        Assert.AreEqual(0 , result);
    }
    [TestMethod]
    public void Geometry_Triangle_CalculatePeramiter_Method_Receives_Negative_height_Returns_Zero()
    {           
        var triangle = new Triangle();
        triangle._side1 = 0;
        triangle._side2 = 0;
        triangle._side3 = 0;
        var result = triangle.CalculatePerimeter();    
        Assert.AreEqual(0, result);
    }
        [TestMethod]
    public void Geometry_Triangle_CalculatePeramiter_Method_Receives_Number_And_Return_Result()
    {
        var triangle = new Triangle();
        triangle._side1 = 10;
        triangle._side2 = 10;
        triangle._side3 = 10;
        var result = triangle.CalculatePerimeter();    
        Assert.AreEqual(30, result);
    }
}