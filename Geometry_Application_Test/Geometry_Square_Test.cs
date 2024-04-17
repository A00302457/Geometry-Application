using Geometry_Application;

namespace Geometry_Application_Test;

[TestClass]
public class Geometry_Square_Test
{
    /////////////////////////////////////////////CalculateArea/////////////////////////////////////////////////
    [TestMethod]
    public void Geometry_Square_CalculateArea_Method_Receives_Zeros_And_Return_Zeros()
    {
        var square = new Square();
        square._side = 0;
        var result = square.CalculateArea();
        Assert.AreEqual(0 , result);
    }
    [TestMethod]
    public void Geometry_Square_CalculateArea_Method_Receives_Negative_Side_Returns_Zero()
    {           
        var square = new Square();
        square.side = -4;      
        var result = square.CalculateArea();         
        Assert.AreEqual(0, result);
    }
        [TestMethod]
    public void Geometry_Square_CalculateArea_Method_Receives_Number_And_Return_Result()
    {
        var square = new Square();
        square._side = 25;
        var result = square.CalculateArea();
        Assert.AreEqual(50, result);
    }

    ////////////////////////////////////////////////CalculatePeramiter///////////////////////////////////////////
     [TestMethod]
     public void Geometry_Square_CalculatePeramiter_Method_Receives_Zeros_And_Return_Zeros()
    {
        var square = new Square();
        square._side = 0;
        var result = square.CalculatePerimeter();
        Assert.AreEqual(0 , result);
    }
    [TestMethod]
    public void Geometry_Square_CalculatePeramiter_Method_Receives_Negative_Side_Returns_Zero()
    {           
        var square = new Square();
        square.side = -4;      
        var result = square.CalculatePerimeter();;         
        Assert.AreEqual(0, result);
    }
        [TestMethod]
    public void Geometry_Square_CalculatePeramiter_Method_Receives_Number_And_Return_Result()
    {
        var square = new Square();
        square._side = 25;
        var result = square.CalculatePerimeter();;
        Assert.AreEqual(100, result);
    }
}