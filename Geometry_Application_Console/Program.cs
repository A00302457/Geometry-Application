// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Geometry_Application;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using System.Configuration;

var featureManagement = new Dictionary<string, string> {{ "FeatureManagement:Square", "true"}, { "FeatureManagement:Rectangle", "true"}, { "FeatureManagement:Triangle", "true"}};

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();

var featureManager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();
if (await featureManager.IsEnabledAsync("Square"))
{
    // Provide access to Square
    var square = new Square();
    Console.WriteLine("Enter side of the Square:- ");
    string strSide = Console.ReadLine() ?? "5";
    if(strSide == ""){strSide = "5";}
    var side = double.Parse(strSide);
    if(side > 0)
    { 
    square._side = side;
    Console.WriteLine($"Area of square :- {square.CalculateArea()}");
    Console.WriteLine($"Peramiter of square :- {square.CalculatePerimeter()}");
    }
    else{
        Console.WriteLine("Side should be in positive number");
        square._side = 0;
    }
}
if (await featureManager.IsEnabledAsync("Rectangle"))
{
    
    var rectangle = new Rectangle();
    Console.WriteLine("Enter height of the Rectangle:- ");
    var strheight = Console.ReadLine() ?? "5";
    if(strheight == ""){ strheight = "5";}
    var height = double.Parse(strheight);
    Console.WriteLine("Enter height of the Rectangle:- ");
    var width = double.Parse(Console.ReadLine() ?? "5");
    if(height > 0){
    rectangle._height = height;
    rectangle._width = width;
    Console.WriteLine($"Area of Rectangle :-  {rectangle.CalculateArea()}");
    Console.WriteLine($"Peramiter of Rectangle :- {rectangle.CalculatePerimeter()}");
    }
    else{
        Console.WriteLine("Side should be in positive number");
        rectangle._height = 0;
        rectangle._width = 0;
    }
}
if (await featureManager.IsEnabledAsync("Triangle"))
{
    // Provide access to Triangle
    var triangle = new Triangle();
    Console.WriteLine("Enter side1 of the Triangle:- ");
    var side1 = double.Parse(Console.ReadLine() ?? "5");
    Console.WriteLine("Enter side2 of the Triangle:- ");
    var side2 = double.Parse(Console.ReadLine() ?? "5");
    Console.WriteLine("Enter side3 of the Triangle:- ");
    var side3 = double.Parse(Console.ReadLine() ?? "5");
    if(side1 > 0)
    {
        triangle._side1 = side1;
        triangle._side2 = side2;
        triangle._side3 = side3;
        Console.WriteLine($"Area of Triangle :- {triangle.CalculateArea()}");
        Console.WriteLine($"Peramiter of Triangle  :- {triangle.CalculatePerimeter()}");
    }
    else{
         Console.WriteLine("Side1 should be in positive number");
         triangle.side1 =0;
         triangle._side2 =0;
         triangle.side3 =0;
    }
}
