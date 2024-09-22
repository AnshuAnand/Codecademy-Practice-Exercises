using System.Net.NetworkInformation;

namespace ArithmeticArchitect;

class Program
{
    static void Main(string[] args)
    {
        double rectangleArea = CalculateRectangleArea(2500, 1500);
        Console.WriteLine($"Value for rectangleArea is {rectangleArea}");
        double halfCircleArea = (CalculateCircleArea(375)) / 2;
        Console.WriteLine($"Value for halfCircleArea is {halfCircleArea}");
        double triangleArea = CalculateTriangleArea(750, 500);
        Console.WriteLine($"Value for triangleArea is {triangleArea}");

        double monumentArea = CalculateMonumentArea(rectangleArea, halfCircleArea, triangleArea);
        Console.WriteLine($"Value for monumentArea is {monumentArea}");
        double monumentFlooringCost = CalculateFlooringCostForMonument(monumentArea);
        Console.WriteLine($"Total flooring cost for monument is: {monumentFlooringCost} pesos");
    }

    static double CalculateRectangleArea(double length, double width)
    {
        double rectangleArea = length * width;
        return rectangleArea;
    }
    static double CalculateCircleArea(double radius)
    {
        double circleArea = Math.PI * Math.Pow(radius, 2);
        return circleArea;
    }

    static double CalculateTriangleArea(double bottom, double height)
    {
        double triangleArea = (0.5) * bottom * height;
        return triangleArea;
    }

    static double CalculateMonumentArea(double rectangleArea = 0, double circleArea = 0, double triangleArea = 0)
    {
        double monumentArea = rectangleArea + circleArea + triangleArea;
        return monumentArea;
    }

    static double CalculateFlooringCostForMonument(double totalMonumentArea)
    {
        double flooringCost = totalMonumentArea * 180;
        decimal flooringCostDecimal = Convert.ToDecimal(flooringCost);
        flooringCost = Convert.ToDouble(Math.Round(flooringCostDecimal, 2));
        return flooringCost;
    }
}
