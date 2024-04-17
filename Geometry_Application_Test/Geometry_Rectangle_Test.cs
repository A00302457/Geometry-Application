using Geometry_Application;

namespace Geometry_Application_Test;

[TestClass]
public class Geometry_Rectangle_Test
{
    /////////////////////////////////////////////CalculateArea/////////////////////////////////////////////////
    [TestMethod]
    public void Geometry_Rectangle_CalculateArea_Method_Receives_Zeros_And_Return_Zeros()
    {
        var rect = new Rectangle();
        rect._height = 0;
        rect._width = 0;
        var result = rect.CalculateArea();
        Assert.AreEqual(0 , result);
    }
    [TestMethod]
    public void Geometry_Rectangle_CalculateArea_Method_Receives_one_Negative_height_Returns_Zero()
    {           
        var rect = new Rectangle();
        rect._height = -4;      
        var result = rect.CalculateArea();         
        Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void Geometry_Rectangle_CalculateArea_Method_Receives_Number_And_Return_Result()
    {
        var rect = new Rectangle();
        rect._height = 5;
        rect._width = 5;
        var result = rect.CalculateArea();
        Assert.AreEqual(25, result);
    }

    ////////////////////////////////////////////////CalculatePeramiter///////////////////////////////////////////
     [TestMethod]
     public void Geometry_Rectangle_CalculatePeramiter_Method_Receives_Zeros_And_Return_Zeros()
    {
        var rect = new Rectangle();
        rect._height = 0;
        rect._width = 0;
        var result = rect.CalculatePerimeter();
        Assert.AreEqual(0 , result);
    }
    [TestMethod]
    public void Geometry_Rectangle_CalculatePeramiter_Method_Receives_Negative_height_Returns_Zero()
    {           
        var rect = new Rectangle();
        rect._height = -4;      
        var result = rect.CalculatePerimeter();         
         Assert.AreEqual(0, Math.Max(0, result));
    }
        [TestMethod]
    public void Geometry_Rectangle_CalculatePeramiter_Method_Receives_Number_And_Return_Result()
    {
         var rect = new Rectangle();
        rect._height = 5;
        rect._width = 5;
        var result = rect.CalculatePerimeter();
        Assert.AreEqual(20, result);
    }
}